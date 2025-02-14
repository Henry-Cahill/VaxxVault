using System;
using VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pneumococcal;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class HandlePneumococcal
   {
      // The Execute method provides a console interface for the user to select an action
      // (Review, Drop, or Load) for handling pneumococcal vaccine data.
      public static async Task Execute()
      {
         // Display options to the user.
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");

         // Read the user's choice from the console.
         var choice = Console.ReadLine()?.Trim();

         // Check if the choice is valid.
         if (string.IsNullOrEmpty(choice))
         {
            Console.WriteLine("Invalid choice. Please select a valid option.");
            return;
         }

         try
         {
            // Execute the corresponding method based on the user's choice.
            switch (choice)
            {
               case "Review":
                  // Call the ReviewXml method to review pneumococcal vaccine data.
                  Vaccine_PneumococcalR.ReviewXml();
                  break;
               case "Drop":
                  // Call the DeleteXmlDataInDatabase method to delete pneumococcal vaccine data.
                  await Vaccine_PneumococcalD.DeleteXmlDataInDatabase();
                  break;
               case "Load":
                  // Call the InsertXmlDataIntoDatabase method to load pneumococcal vaccine data.
                  VaccinePneumococcalLoader.InsertXmlDataIntoDatabase();
                  break;
               default:
                  // Handle invalid choices.
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         catch (Exception ex)
         {
            // Handle any exceptions that occur during method execution.
            Console.WriteLine($"An error occurred: {ex.Message}");
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 