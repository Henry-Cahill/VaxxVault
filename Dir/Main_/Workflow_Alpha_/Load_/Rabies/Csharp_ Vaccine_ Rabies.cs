using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rabies
{
   internal class Vaccine_RabiesL
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\sql_log.txt";
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt";

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
            "4.60" => @"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData- Rabies-508.xml",
            "4.59" => @"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData- Rabies-508.xml",
            "4.58" => @"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData- Rabies-508.xml",
            "4.57" => @"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData- Rabies-508.xml",
            _ => null
         };

         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid version selected.");
            return;
         }

         string connectionString = "Server=HLC-Laptop\\SQLEXPRESS; Database=CDSi_4.60; Integrated Security=True;";
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
                  VALUES (20, @XmlData);
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
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 