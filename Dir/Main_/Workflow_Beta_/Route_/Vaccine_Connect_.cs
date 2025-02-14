using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using VaxxVault_V0004.Dir.Main_;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Beta_.Route_
{
   internal class Vaccine_Connect_
   {
      private static SqlConnection GetSqlConnection(SqlCredential credentials = null)
      {
         string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=CDSi_4.60;Integrated Security=True;Encrypt=False";
         return credentials != null ? new SqlConnection(connectionString, credentials) : new SqlConnection(connectionString);
      }

      public static void ViewingOptions()
      {
         DisplayLegalDisclaimer();

         if (!UserAgreedToTerms())
         {
            Console.WriteLine("You did not agree to the terms. Exiting...");
            return;
         }

         DisplayMenu();
         HandleUserSelection();
      }

      private static void DisplayLegalDisclaimer()
      {
         Console.WriteLine("LEGAL DISCLAIMER:");
         Console.WriteLine("By authorizing the execution of these commands, you acknowledge and agree that:");
         Console.WriteLine("1. You have the necessary permissions and authority to execute these commands.");
         Console.WriteLine("2. Executing these commands will modify the database, and you understand the consequences.");
         Console.WriteLine("3. You accept full responsibility for any changes made to the database.");
         Console.WriteLine("4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.");
         Console.WriteLine("5. You have reviewed and understand the commands that will be executed.");
         Console.WriteLine("Do you agree to these terms? (yes/no)");
      }

      private static bool UserAgreedToTerms()
      {
         string input = Console.ReadLine();
         return input?.ToLower() == "yes";
      }

      private static void DisplayMenu()
      {
         Console.WriteLine("Displaying menu to the user.");
         Console.WriteLine("Select the script to execute:");
         Console.WriteLine("1. Vaccine Select");
         Console.WriteLine("2. Vaccine Definition");
         Console.WriteLine("3. DataFrame");
         Console.WriteLine("4. Validation");
         Console.WriteLine("5. Exit");
         Console.WriteLine("6. Execute all modules in order");
      }

      private static void HandleUserSelection()
      {
         string input = Console.ReadLine();
         switch (input)
         {
            case "1":
               ExecuteQuery("SELECT ID, XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName FROM VaccineData;", "ID", "SeriesName");
               break;
            case "2":
               ExecuteQuery("SELECT * FROM VaccineDefinition;", "ID", "Definition");
               break;
            case "3":
               ExecuteQuery("SELECT * FROM DataFrame;", "ID", "Data");
               break;
            case "4":
               ExecuteQuery("SELECT * FROM Validation;", "ID", "Status");
               break;
            case "5":
               Console.WriteLine("Exiting...");
               break;
            case "6":
               ExecuteAllModules();
               break;
            default:
               Console.WriteLine("Invalid selection. Please try again.");
               break;
         }
      }

      private static void ExecuteQuery(string query, params string[] columns)
      {
         using (SqlConnection connection = GetSqlConnection())
         {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               using (SqlDataReader reader = command.ExecuteReader())
               {
                  while (reader.Read())
                  {
                     foreach (var column in columns)
                     {
                        Console.Write($"{column}: {reader[column]} ");
                     }
                     Console.WriteLine();
                  }
               }
            }
         }
      }

      private static void ExecuteAllModules()
      {
         ExecuteQuery("SELECT ID, XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName FROM VaccineData;", "ID", "SeriesName");
         ExecuteQuery("SELECT * FROM VaccineDefinition;", "ID", "Definition");
         ExecuteQuery("SELECT * FROM DataFrame;", "ID", "Data");
         ExecuteQuery("SELECT * FROM Validation;", "ID", "Status");
      }
   }
}