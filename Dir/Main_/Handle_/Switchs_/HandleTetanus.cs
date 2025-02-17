using System;
using VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Tetanus;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class HandleTetanus
   {
      public static async Task Execute()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");

         var choice = Console.ReadLine()?.Trim()?.ToLower();

         if (string.IsNullOrEmpty(choice))
         {
            Console.WriteLine("Invalid choice. Please select a valid option.");
            return;
         }

         try
         {
            switch (choice)
            {
               case "review":
                  VaccineTetanusReview.ReviewXml();
                  break;
               case "drop":
                  await VaccineTetanusDrop.DeleteXmlDataInDatabase();
                  break;
               case "load":
                  VaccineTetanusLoader.InsertXmlDataIntoDatabase();
                  break;
               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 