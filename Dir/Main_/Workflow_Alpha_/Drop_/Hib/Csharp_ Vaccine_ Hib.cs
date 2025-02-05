using System;
using System.IO;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.HepB;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Hib
{
   internal class Vaccine_HibD
   {
      public static void DeleteXmlDataInDatabase()
      {
         string version = VersionHelper.GetVersionFromUser();
         string filePath = FilePathHelper_Hib.GetFilePath(version);

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

         SqlCommandExecutor_Hib.ExecuteSqlCommand(connectionString, xmlData);
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
