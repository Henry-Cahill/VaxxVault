using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VaxxVault_V0003.Dir.Main_.Handle_.XML_;
using VaxxVault_V0003.Dir.Main_.Workflow_Beta_.Route_;

namespace VaxxVault_V0003.Dir.Main_.Handle_
{
   /// <summary>
   /// Provides methods to handle maintenance operations.
   /// </summary>
   internal static class Maintenance
   {
      private const string ExitOption = "6";

      /// <summary>
      /// Handles the maintenance operations.
      /// </summary>
      public static async Task HandleAsync()
      {
         bool keepRunning = true;

         while (keepRunning)
         {
            DisplayMenu();

            string? choice = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(choice))
            {
               Console.WriteLine("Invalid choice. Please select a valid option.");
               continue;
            }

            if (choice == ExitOption)
            {
               if (await ConfirmExitAsync())
               {
                  keepRunning = false;
                  Console.WriteLine("\nExiting the program.\n");
               }
            }
            else
            {
               await HandleChoiceAsync(choice);
            }
         }
      }

      /// <summary>
      /// Displays the maintenance menu options.
      /// </summary>
      private static void DisplayMenu()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("   1.A (NATIVE) XML to Database");
         Console.WriteLine("   1.B (NATIVE) XLSX to Database");
         Console.WriteLine("   1.C CSV/XLSX review in Console");
         Console.WriteLine("   2. Database content Review and Packaging");
         Console.WriteLine("   3. Data cleaning and Sending to Database");
         Console.WriteLine("   4. System");
         Console.WriteLine("   5. Privacy");
         Console.WriteLine("   6. Exit");
      }

      /// <summary>
      /// Handles the user's choice from the menu.
      /// </summary>
      /// <param name="choice">The user's choice.</param>
      private static async Task HandleChoiceAsync(string choice)
      {
         switch (choice)
         {
            case "1.A":
               XML.HandleXMLData();
               break;
            case "1.B":
               await HandleCSVOrXLSXAsync();
               break;
            case "2":
               Vaccine_Connect_.ViewingOptions();
               break;
            case "3":
               // Handle Data cleaning and Sending to Database
               break;
            case "4":
               // Handle System
               break;
            case "5":
               // Handle Privacy
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }

      /// <summary>
      /// Handles the CSV or XLSX file input.
      /// </summary>
      private static async Task HandleCSVOrXLSXAsync()
      {
         Console.WriteLine("Enter the path to the CSV or XLSX file:");
         string? filePath = Console.ReadLine();
         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid file path.");
            return;
         }
         if (File.Exists(filePath))
         {
            if (filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
               await HandleCSVAsync(filePath);
            }
            else if (filePath.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
               await HandleXLSXAsync(filePath);
            }
            else
            {
               Console.WriteLine("Unsupported file format.");
            }
         }
         else
         {
            Console.WriteLine("File not found.");
         }
      }

      /// <summary>
      /// Handles the CSV file input.
      /// </summary>
      /// <param name="filePath">The path to the CSV file.</param>
      private static async Task HandleCSVAsync(string filePath)
      {
         using (var reader = new StreamReader(filePath))
         {
            string? line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
               Console.WriteLine(line);
            }
         }
      }

      /// <summary>
      /// Handles the XLSX file input.
      /// </summary>
      /// <param name="filePath">The path to the XLSX file.</param>
      private static async Task HandleXLSXAsync(string filePath)
      {
         await Task.Run(() =>
         {
            using (var workbook = new XLWorkbook(filePath))
            {
               var worksheet = workbook.Worksheets.First();
               foreach (var row in worksheet.RowsUsed())
               {
                  foreach (var cell in row.CellsUsed())
                  {
                     Console.Write($"{cell.Value}\t");
                  }
                  Console.WriteLine();
               }
            }
         });
      }

      /// <summary>
      /// Confirms if the user wants to exit the application.
      /// </summary>
      /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating if the user confirmed the exit.</returns>
      private static async Task<bool> ConfirmExitAsync()
      {
         Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
         string? exitChoice = (await Task.Run(() => Console.ReadLine()))?.ToLower();
         return exitChoice == "yes";
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.