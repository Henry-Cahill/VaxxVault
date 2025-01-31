// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;
using System.Net;
using System.Security.Principal;
using VaxxVault.Tables;

namespace VaxxVault
{
   class Program
   {
      public static void Main(string[] args)
      {
         // Initialization phase: Initialize variables, create instances, and prompt user for input.
         // Generate the checkboard pattern
         CheckerboardGenerator.GenerateCheckerboard();

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
            Console.WriteLine("\nSelect a Table:");
            Console.WriteLine("1. View Seasonal Recommendation");
            Console.WriteLine("2. View Recurring Dose");
            Console.WriteLine("3. View Conditional Skip");
            Console.WriteLine("5. View Age");
            Console.WriteLine("\nAdditional Selections:");
            Console.WriteLine("6. Calculations and Results");
            Console.WriteLine("7. Exit\n");


            switch (Console.ReadLine())
            {
               case "1":
                  Console.WriteLine("\nDisplaying Seasonal Recommendations Table");
                  Console.WriteLine("\nPlease select a sub-option:");
                  Console.WriteLine(" 0. Full Table View");
                  Console.WriteLine(" 1. Fist Attribute");
                  Console.WriteLine(" 2. Two Attributes\n");

                  switch (Console.ReadLine())
                  {
                     case "0":
                        Console.WriteLine("\nDisplaying Seasonal Recommendations Table");
                        Seasonal_Recommendation.Select_All();
                        break;
                     case "1":
                        Console.WriteLine("\nDisplaying First Attribute - Seasonal Recommendations");
                        Seasonal_Recommendation.Attribute1();
                        break;
                     case "2":
                        Console.WriteLine("\nDisplaying Two Attributes - Seasonal Recommendations");
                        Seasonal_Recommendation.Attribute2();
                        break;
                     default:
                        Console.WriteLine("\nReturning to Table Selection");
                        break;
                  }
                  break;

               case "2":
                  Console.WriteLine("\nDisplaying Recurring Dose Table");
                  Console.WriteLine("\nPlease select a sub-option:");
                  Console.WriteLine(" 0. Full Table View");
                  Console.WriteLine(" 1. Fist Attribute\n");

                  switch (Console.ReadLine())
                  {
                     case "0":
                        Console.WriteLine("\nDisplaying Recurring Dose Table");
                        Recurring_Dose.Select_All();
                        break;
                     case "1":
                        Console.WriteLine("\nDisplaying First Attribute - Recurring Dose");
                        Recurring_Dose.Attribute1();
                        break;
                     default:
                        Console.WriteLine("\nReturning to Table Selection");
                        break;
                  }
                  break;

               case "3":
                  Console.WriteLine("\nDisplaying Conditional Skip Table");
                  Console.WriteLine("\nPlease select a sub-option:");
                  Console.WriteLine(" 0. Full Table View");
                  Console.WriteLine(" 1. First Attribute");
                  Console.WriteLine(" 2. Two Attributes");
                  Console.WriteLine(" 3. Three Attributes");
                  Console.WriteLine(" 4. Four Attribute");
                  Console.WriteLine(" 5. Five Attributes");
                  Console.WriteLine(" 6. Six Attributes");
                  Console.WriteLine(" 7. Seven Attributes");
                  Console.WriteLine(" 8. Eight Attributes");
                  Console.WriteLine(" 9. Nine Attributes");
                  Console.WriteLine("10. Ten Attributes");
                  Console.WriteLine("11. Eleven Attributes");
                  Console.WriteLine("12. Twelve Attributes");
                  Console.WriteLine("13. Thirteen Attributes");
                  Console.WriteLine("14. Fourteen Attributes");


                  switch (Console.ReadLine())
                  {
                     case "0":
                        Console.WriteLine("\nDisplaying Conditional Skip Table");
                        Conditional_Skip.Select_All();
                        break;
                     case "1":
                        Console.WriteLine("\nDisplaying First Attribute - Conditional Skip");
                        Conditional_Skip.Attribute1();
                        break;
                     case "2":
                        Console.WriteLine("\nDisplaying Two Attributes - Conditional Skip");
                        Conditional_Skip.Attribute2();
                        break;
                     case "3":
                        Console.WriteLine("\nDisplaying Three Attributes - Conditional Skip");
                        Conditional_Skip.Attribute3();
                        break;
                     case "4":
                        Console.WriteLine("\nDisplaying Four Attributes - Conditional Skip");
                        Conditional_Skip.Attribute4();
                        break;
                     case "5":
                        Console.WriteLine("\nDisplaying Five Attributes - Conditional Skip");
                        Conditional_Skip.Attribute5();
                        break;
                     case "6":
                        Console.WriteLine("\nDisplaying Six Attributes - Conditional Skip");
                        Conditional_Skip.Attribute6();
                        break;
                     case "7":
                        Console.WriteLine("\nDisplaying Seven Attributes - Conditional Skip");
                        Conditional_Skip.Attribute7();
                        break;
                     case "8":
                        Console.WriteLine("\nDisplaying Eight Attributes - Conditional Skip");
                        Conditional_Skip.Attribute8();
                        break;
                     case "9":
                        Console.WriteLine("\nDisplaying Nine Attributes - Conditional Skip");
                        Conditional_Skip.Attribute9();
                        break;
                     case "10":
                        Console.WriteLine("\nDisplaying Ten Attributes - Conditional Skip");
                        Conditional_Skip.Attribute10();
                        break;
                     case "11":
                        Console.WriteLine("\nDisplaying Eleven Attributes - Conditional Skip");
                        Conditional_Skip.Attribute11();
                        break;
                     case "12":
                        Console.WriteLine("\nDisplaying Twelve Attributes - Conditional Skip");
                        Conditional_Skip.Attribute12();
                        break;
                     case "13":
                        Console.WriteLine("\nDisplaying Thirteen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute13();
                        break;
                     case "14":
                        Console.WriteLine("\nDisplaying Fourteen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute14();
                        break;
                     case "15":
                        Console.WriteLine("\nDisplaying Fifteen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute15();
                        break;
                     case "16":
                        Console.WriteLine("\nDisplaying Sixteen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute16();
                        break;
                     case "17":
                        Console.WriteLine("\nDisplaying Seventeen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute17();
                        break;
                     case "18":
                        Console.WriteLine("\nDisplaying Eighteen Attributes - Conditional Skip");
                        Conditional_Skip.Attribute18();
                        break;
                     default:
                        Console.WriteLine("\nReturning to Table Selection");
                        break;
                  }
                  break;

               case "4":



                  break;

               case "5":
                  Console.WriteLine("\nDisplaying Age Table");
                  Age.Select_All();
                  break;
               
               
               case "6":
                  Console.WriteLine();
                  vaxxVaultData.DisplayDate();
                  vaxxVaultData.DisplayHeartRates();
                  vaxxVaultData.DisplayBMI();
                  break;



               case "7":
                  keepRunning = false;
                  Console.WriteLine("\nExiting the program.\n");
                  break;
               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;

            }
         }

         // Generate the checkboard pattern
         CheckerboardGenerator.GenerateCheckerboard();
      }
   }
}