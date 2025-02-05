using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Cholera
{
   internal class Vaccine_CholeraD
   {
      private const string LogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\sql_log.txt";
      private const string ErrorLogFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt";

      public static void DeleteXmlDataInDatabase()
      {
         string version = VersionHelper.GetVersionFromUser();
         string filePath = FilePathHelper.GetFilePath(version);

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
            Console.WriteLine("Authorization denied. Exiting...");
            return;
         }

         SqlCommandExecutor.ExecuteSqlCommand(connectionString, xmlData);
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
