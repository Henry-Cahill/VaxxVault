using System;
using System.IO;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Tetanus;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Tetanus
{
   internal class Vaccine_TetanusD
   {
      public static void DeleteXmlDataInDatabase()
      {
         // Read connection string from file
         string connectionStringFilePath = "A:\\New.New\\VaxxVault\\Dir\\Config_\\connectionString.txt";
         string connectionString = File.ReadAllText(connectionStringFilePath).Trim();

         try
         {
            LegalDisclaimerHelper.DisplayLegalDisclaimer();
            if (!UserAuthorizationHelper.GetUserAuthorization())
            {
               Console.WriteLine("Authorization denied. Exiting...");
               return;
            }

            // Execute SQL command to drop a row
            SqlCommandExecutor_Tetanus.ExecuteSqlCommandAsync(connectionString, "DELETE FROM VaccineData WHERE Id = @Id;");
         }
         catch (IOException ex)
         {
            Console.WriteLine($"IO error: {ex.Message}");
            // Log exception
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Log exception
         }

         Console.WriteLine("Reminder: Please load another version of the Tetanus XML data before proceeding.");
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
