using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace VaxxVault_V0002.Dir.Load_
{
   internal class Vaccine_OrthopoxvirusL
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault_V0002\\Dir\\temp\\sql_log.txt";
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault_V0002\\Dir\\temp\\error_log.txt";

      private static void DisplayLegalDisclaimer()
      {
         Console.WriteLine("LEGAL DISCLAIMER:");
         Console.WriteLine("By authorizing the execution of these commands, you acknowledge and agree that:");
         Console.WriteLine("1. You have the necessary permissions and authority to execute these commands.");
         Console.WriteLine("2. Executing these commands will modify the database, and you understand the consequences.");
         Console.WriteLine("3. You accept full responsibility for any changes made to the database.");
         Console.WriteLine("4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.");
         Console.WriteLine("5. You have reviewed and understand the commands that will be executed.");
         Console.WriteLine("Do you authorize the execution of these commands? (yes/no)");
      }

      private static bool GetUserAuthorization()
      {
         string response = Console.ReadLine();
         return response?.Trim().ToLower() == "yes";
      }

      public static void InsertXmlDataIntoDatabase()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();

         if (string.IsNullOrEmpty(version))
         {
            version = "4.60";
         }

         string filePath = version switch
         {
            "4.60" => @"A:\New.New\VaxxVault_V0002\Import\Version 4.60 - 508\XML\AntigenSupportingData- Orthopoxvirus-508.xml",
            "4.59" => @"A:\New.New\VaxxVault_V0002\Import\Version 4.59 - 508\XML\AntigenSupportingData- Orthopoxvirus-508.xml",
            "4.58" => @"A:\New.New\VaxxVault_V0002\Import\Version 4.58 - 508\XML\AntigenSupportingData- Orthopoxvirus-508.xml",
            "4.57" => @"A:\New.New\VaxxVault_V0002\Import\Version 4.57 - 508\XML\AntigenSupportingData- Orthopoxvirus-508.xml",
            _ => null
         };

         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid version selected.");
            return;
         }

         string connectionString = "Server=HLC-Laptop\\SQLEXPRESS; Database=CDSi_4.60; Integrated Security=True;";
         string xmlData = File.ReadAllText(filePath);

         DisplayLegalDisclaimer();
         if (!GetUserAuthorization())
         {
            Console.WriteLine("Authorization denied. Exiting.");
            return;
         }

         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();

            string sql = @"
                  SET IDENTITY_INSERT VaccineData ON;
                  INSERT INTO VaccineData (Id, XmlData)
                  VALUES (16, @XmlData);
                  SET IDENTITY_INSERT VaccineData OFF;";

            LogSqlStatement(sql);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
               command.Parameters.Add(new SqlParameter("@XmlData", SqlDbType.Xml) { Value = xmlData });

               try
               {
                  command.ExecuteNonQuery();
               }
               catch (Exception ex)
               {
                  LogError(ex);
                  throw;
               }
            }
         }
      }

      static void LogSqlStatement(string sqlStatement)
      {
         EnsureDirectoryExists(LogFilePath);
         try
         {
            Console.WriteLine("Attempting to log SQL statement to: " + LogFilePath);
            using (StreamWriter writer = new StreamWriter(LogFilePath, true))
            {
               writer.WriteLine("Date: " + DateTime.Now.ToString());
               writer.WriteLine("SQL Statement: " + sqlStatement);
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("SQL statement logged: " + sqlStatement);
         }
         catch (Exception ex)
         {
            Console.WriteLine("Failed to log SQL statement: " + ex.Message);
         }
      }

      static void EnsureDirectoryExists(string filePath)
      {
         string directoryPath = Path.GetDirectoryName(filePath);
         if (!Directory.Exists(directoryPath))
         {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine("Created directory: " + directoryPath);
         }
      }

      static void LogError(Exception ex)
      {
         EnsureDirectoryExists(ErrorLogFilePath);
         try
         {
            using (StreamWriter writer = new StreamWriter(ErrorLogFilePath, true))
            {
               writer.WriteLine("Date: " + DateTime.Now.ToString());
               writer.WriteLine("Message: " + ex.Message);
               writer.WriteLine("StackTrace: " + ex.StackTrace);
               writer.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("Error logged: " + ex.Message);
         }
         catch (Exception logEx)
         {
            Console.WriteLine("Failed to log error: " + logEx.Message);
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
