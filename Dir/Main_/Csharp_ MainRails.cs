using System;
using VaxxVault_V0004.Dir.Handle;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// MainRails class handles the main tasks and operations of the VaxxVault application.
   /// </summary>
   public class MainRails
   {
      /// <summary>
      /// Handles another task.
      /// </summary>
      public static void HandleAnotherTask()
      {
         // Initialization phase: Initialize variables, create instances, and prompt user for input.
         // Generate the checkerboard pattern
         CheckerboardGenerator.GenerateCheckerboard();

         Account vaxxVaultAccount = new Account("DefaultName", "DefaultUsername");
         AccountManager.ManageAccount(vaxxVaultAccount);

         Data vaxxVaultData = new Data("John", "Doe", 30, "Male", 2025, 70, 180, 1, 15, 1995);

         // Processing phase: Perform calculations and display results.
         vaxxVaultData.DisplayDate();
         vaxxVaultData.DisplayHeartRates();
         vaxxVaultData.DisplayBMI();

         // Termination phase: Provide options to view additional information or exit the program.
         bool keepRunning = true;

         while (keepRunning)
         {
            Console.WriteLine("\nSelect one of the Following Options:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("0. ");
            Console.WriteLine("1. View Seasonal Recommendation");
            Console.WriteLine("2. View Recurring Dose");
            Console.WriteLine("3. View Conditional Skip");
            Console.WriteLine("4. ");
            Console.WriteLine("5. View Age");
            Console.WriteLine("\nAdditional Selections:");
            Console.WriteLine("6. Calculations and Results");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Exit\n");

            string? mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
               case "0":
                  break;

               case "1":
                  // HandleSeasonalRecommendation();
                  break;

               case "2":
                  // HandleRecurringDose();
                  break;

               case "3":
                  // HandleConditionalSkip();
                  break;

               case "4":
                  // Placeholder for future functionality
                  break;

               case "5":
                  Console.WriteLine("\nDisplaying Age Table");
                  // Age.Select_All();
                  break;

               case "6":
                  Console.WriteLine();
                  vaxxVaultData.DisplayDate();
                  vaxxVaultData.DisplayHeartRates();
                  vaxxVaultData.DisplayBMI();
                  break;

               case "8":
                  Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
                  string? exitChoice = Console.ReadLine()?.ToLower();
                  if (exitChoice == "yes")
                  {
                     keepRunning = false;
                     Console.WriteLine("\nExiting the program.\n");
                  }
                  break;

               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         // Generate the checkerboard pattern
         CheckerboardGenerator.GenerateCheckerboard();
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.