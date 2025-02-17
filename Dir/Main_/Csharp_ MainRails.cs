using System;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// MainRails class handles the main tasks and operations of the VaxxVault application.
   /// </summary>
   public class MainRails
   {
      private enum MenuOption
      {
         Placeholder0,
         SeasonalRecommendation,
         RecurringDose,
         ConditionalSkip,
         Placeholder4,
         ViewAge,
         CalculationsAndResults,
         Exit = 8
      }

      /// <summary>
      /// Handles another task.
      /// </summary>
      public static void HandleAnotherTask()
      {
         Initialize();

         bool keepRunning = true;
         while (keepRunning)
         {
            DisplayMenu();
            string? mainChoice = Console.ReadLine();
            keepRunning = HandleMenuChoice(mainChoice);
         }
      }

      private static void Initialize()
      {
         CheckerboardGenerator.GenerateCheckerboard();

         Account vaxxVaultAccount = new Account("DefaultName", "DefaultUsername");
         string newUsername = AccountManager.GetNewUsername();
         AccountManager.ManageAccount(vaxxVaultAccount, newUsername);

         Data vaxxVaultData = new Data("John", "Doe", 30, "Male", 2025, 70, 180, 1, 15, 1995);
         vaxxVaultData.DisplayDate();
         vaxxVaultData.DisplayHeartRates();
         vaxxVaultData.DisplayBMI();
      }

      private static void DisplayMenu()
      {
         Console.WriteLine("\nSelect one of the Following Options:\n" +
                           "-------------------------------------\n" +
                           "0. \n" +
                           "1. View Seasonal Recommendation\n" +
                           "2. View Recurring Dose\n" +
                           "3. View Conditional Skip\n" +
                           "4. \n" +
                           "5. View Age\n" +
                           "\nAdditional Selections:\n" +
                           "6. Calculations and Results\n" +
                           "7. \n" +
                           "8. Exit\n");
      }

      private static bool HandleMenuChoice(string? mainChoice)
      {
         if (Enum.TryParse(mainChoice, out MenuOption option))
         {
            switch (option)
            {
               case MenuOption.Placeholder0:
               case MenuOption.Placeholder4:
                  Console.WriteLine("\nDisplaying Placeholder\nPlaceholder for future functionality");
                  break;

               case MenuOption.SeasonalRecommendation:
                  Console.WriteLine("\nDisplaying Seasonal Recommendation\nPlaceholder for future functionality");
                  // HandleSeasonalRecommendation();
                  break;

               case MenuOption.RecurringDose:
                  Console.WriteLine("\nDisplaying Recurring Dose\nPlaceholder for future functionality");
                  // HandleRecurringDose();
                  break;

               case MenuOption.ConditionalSkip:
                  Console.WriteLine("\nDisplaying Conditional Skip\nPlaceholder for future functionality");
                  // HandleConditionalSkip();
                  break;

               case MenuOption.ViewAge:
                  Console.WriteLine("\nDisplaying Age Table\nPlaceholder for future functionality");
                  // Age.Select_All();
                  break;

               case MenuOption.CalculationsAndResults:
                  DisplayCalculationsAndResults();
                  break;

               case MenuOption.Exit:
                  return ConfirmExit();

               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         else
         {
            Console.WriteLine("Invalid choice. Please select a valid option.");
         }

         return true;
      }

      private static void DisplayCalculationsAndResults()
      {
         Data vaxxVaultData = new Data("John", "Doe", 30, "Male", 2025, 70, 180, 1, 15, 1995);
         vaxxVaultData.DisplayDate();
         vaxxVaultData.DisplayHeartRates();
         vaxxVaultData.DisplayBMI();
      }

      private static bool ConfirmExit()
      {
         Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
         string? exitChoice = Console.ReadLine()?.ToLower();
         if (exitChoice == "yes")
         {
            Console.WriteLine("\nExiting the program.\n");
            return false;
         }

         return true;
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.