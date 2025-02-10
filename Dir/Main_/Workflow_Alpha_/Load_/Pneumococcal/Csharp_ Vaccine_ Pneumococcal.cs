using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Pneumococcal
{
   internal class Vaccine_PneumococcalL
   {
      private const string ConnectionStringFilePath = "Dir/Config_/connectionString.txt";

      public static void InsertXmlDataIntoDatabase()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();

         if (string.IsNullOrEmpty(version))
         {
            version = "4.60";
         }

         try
         {
            FilePathHelper_Pneumococcal.InitializeConfiguration();
            string filePath = FilePathHelper_Pneumococcal.GetFilePath(version);

            if (string.IsNullOrEmpty(filePath))
            {
               Console.WriteLine("Invalid version selected.");
               return;
            }

            string connectionString = File.ReadAllText(ConnectionStringFilePath);
            string xmlData = File.ReadAllText(filePath);

            LegalDisclaimerHelper.DisplayLegalDisclaimer();
            if (!UserAuthorizationHelper.GetUserAuthorization())
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
                  VALUES (18, @XmlData);
                  SET IDENTITY_INSERT VaccineData OFF;";

               SqlLogger.LogSqlStatement(sql);

               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                  command.Parameters.Add(new SqlParameter("@XmlData", SqlDbType.Xml) { Value = xmlData });

                  try
                  {
                     command.ExecuteNonQuery();
                  }
                  catch (Exception ex)
                  {
                     ErrorLogger.LogError(ex);
                     throw;
                  }
               }
            }
         }
         catch (FileNotFoundException ex)
         {
            Console.WriteLine($"File not found: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
            ErrorLogger.LogError(ex);
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.