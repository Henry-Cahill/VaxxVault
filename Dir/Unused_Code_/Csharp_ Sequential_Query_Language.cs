using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir.Archive_
{
   public class SqlCleaner
   {
      private static StreamWriter logWriter;

      public static void StartLogging(string logFilePath)
      {
         logWriter = new StreamWriter(logFilePath) { AutoFlush = true };
      }

      public static void StopLogging()
      {
         logWriter?.Close();
      }

      public static void Log(string message)
      {
         string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
         Console.WriteLine($"{timestamp}: {message}");
         logWriter?.WriteLine($"{timestamp}: {message}");
      }

      public static List<string> ExtractInsertStatements(string script)
      {
         Log("Extracting INSERT statements...");
         var insertStatements = new List<string>();

         string pattern = @"INSERT INTO .+?;";
         MatchCollection matches = Regex.Matches(script, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);

         foreach (Match match in matches)
         {
            insertStatements.Add(match.Value);
         }

         Log($"{insertStatements.Count} INSERT statements extracted.");
         return insertStatements;
      }

      public static string CleanInsertStatement(string statement)
      {
         Log($"Cleaning statement: {statement}");

         // Ensure semicolon at the end of the statement
         statement = EnsureSemicolons(statement);

         // Remove erroneous 'IS NOT NULL'
         statement = RemoveErroneousIsNotNull(statement);

         // Fix non-boolean expressions
         statement = FixNonBooleanExpressions(statement);

         // Remove duplicate labels by adding an incrementing suffix
         statement = RemoveDuplicateLabels(statement);

         // Close unclosed string literals
         statement = CloseUnclosedStrings(statement);

         // Ensure all CTEs are properly terminated
         statement = EnsureCTETermination(statement);

         // Fix syntax errors related to commas and quotes
         statement = FixSyntaxErrors(statement);

         Log("Statement cleaned.");
         return statement;
      }

      public static string EnsureSemicolons(string statement)
      {
         Log("Ensuring semicolons at the end of the statement...");
         if (!statement.Trim().EndsWith(";"))
         {
            statement = statement.Trim() + ";";
         }
         Log("Semicolon ensured.");
         return statement;
      }

      public static string RemoveErroneousIsNotNull(string statement)
      {
         Log("Removing erroneous 'IS NOT NULL'...");
         statement = statement.Replace(" IS NOT NULL", "");
         Log("'IS NOT NULL' removed.");
         return statement;
      }

      public static string FixNonBooleanExpressions(string statement)
      {
         Log("Fixing non-boolean expressions...");
         statement = Regex.Replace(statement, @"(patient)", "patient IS NOT NULL", RegexOptions.IgnoreCase);
         Log("Non-boolean expressions fixed.");
         return statement;
      }

      public static string RemoveDuplicateLabels(string statement)
      {
         Log("Removing duplicate labels...");
         var labelCounter = new Dictionary<string, int>();
         statement = Regex.Replace(statement, @"(?<label>\bvisit\b|\bhttps\b)", m =>
         {
            var label = m.Groups["label"].Value;
            if (!labelCounter.ContainsKey(label))
            {
               labelCounter[label] = 1;
               return label;
            }
            else
            {
               return $"{label}_{labelCounter[label]++}";
            }
         }, RegexOptions.IgnoreCase);
         Log("Duplicate labels removed.");
         return statement;
      }

      public static string CloseUnclosedStrings(string statement)
      {
         Log("Closing unclosed string literals...");
         statement = Regex.Replace(statement, @"'([^']*)$", "'$1'", RegexOptions.IgnoreCase);
         Log("Unclosed string literals closed.");
         return statement;
      }

      public static string EnsureCTETermination(string statement)
      {
         Log("Ensuring proper termination of CTEs...");
         statement = Regex.Replace(statement, @"WITH\s+\w+\s+AS\s*\(.*?\);", m =>
         {
            return m.Value.EndsWith(";") ? m.Value : m.Value + ";";
         }, RegexOptions.IgnoreCase | RegexOptions.Singleline);
         Log("CTEs properly terminated.");
         return statement;
      }

      public static string FixSyntaxErrors(string statement)
      {
         Log("Fixing syntax errors related to commas and quotes...");
         // Ensure commas between values
         statement = Regex.Replace(statement, @"\sVALUES\s*\(([^;]+)\)\s*;", m =>
         {
            var values = m.Groups[1].Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var cleanedValues = string.Join(",", values.Select(v => v.Trim()));
            return $" VALUES ({cleanedValues});";
         }, RegexOptions.IgnoreCase);

         // Ensure quotes are properly escaped
         statement = statement.Replace("''", "'");
         statement = Regex.Replace(statement, @"(?<!')'(?!')", "''");

         Log("Syntax errors fixed.");
         return statement;
      }
   }

}