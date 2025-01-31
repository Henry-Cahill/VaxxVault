using System;
using System.IO;
using System.Diagnostics;
using VaxxVault_V0002.Dir.Python_;
using VaxxVault_V0002.Dir.Load_;
using VaxxVault_V0002.Dir.Review_;
using VaxxVault_V0002.Dir.Drop_;
using VaxxVault_V0002.Dir.Handle;
using Python.Runtime;

namespace VaxxVault_V0002.Dir
{
   class VaxxVault_V0002
   {
      public static async Task Main(string[] args)
      {
         // Initialization phase: Initialize variables, create instances, and prompt user for input.
         // Generate the checkboard pattern

         await Task.Run(() => CheckerboardGenerator.GenerateCheckerboard());

         Account vaxxVaultAccount = new Account();
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
            Console.WriteLine("   Maintenance");
            Console.WriteLine("0. Python");
            Console.WriteLine("1. View Seasonal Recommendation");
            Console.WriteLine("2. View Recurring Dose");
            Console.WriteLine("3. View Conditional Skip");
            Console.WriteLine("4. ");
            Console.WriteLine("5. View Age");
            Console.WriteLine("\nAdditional Selections:");
            Console.WriteLine("6. Calculations and Results");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Exit\n");

            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
               case "Maintenance":
                  Maintenance.Handle();
                  break;

               case "0":
                  Vaccine_Cholera_Py.Python();
                  break;

               case "1":
                  //HandleSeasonalRecommendation();
                  break;

               case "2":
                  //HandleRecurringDose();
                  break;

               case "3":
                  //HandleConditionalSkip();
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
                  keepRunning = false;
                  Console.WriteLine("\nExiting the program.\n");
                  break;

               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         // Generate the checkboard pattern
         await Task.Run(() => CheckerboardGenerator.GenerateCheckerboard());
      }
   }
}


