using System;
using VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Dengue;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class HandleDengue
   {
      // The Execute method provides a console interface for the user to select an action
      // (Review, Drop, or Load) for handling dengue vaccine data.
      public static async Task Execute()
      {
         // Display options to the user.
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");

         // Read the user's choice from the console.
         var choice = Console.ReadLine()?.Trim()?.ToLower();

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
               case "review":
                  // Call the ReviewXml method to review dengue vaccine data.
                  VaccineDengueReview.ReviewXml();
                  break;
               case "drop":
                  // Call the DeleteXmlDataInDatabase method to delete dengue vaccine data.
                  await VaccineDengueDrop.DeleteXmlDataInDatabase();
                  break;
               case "load":
                  // Call the InsertXmlDataIntoDatabase method to load dengue vaccine data.
                  VaccineDengueLoader.InsertXmlDataIntoDatabase();
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