using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaxxVault_V0003.Dir.Main_.Workflow_Beta_.Route_;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_
{
   internal class Maintenance
   {
      public static void Handle()
      {
         bool keepRunning = true;

         while (keepRunning)
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

            switch (Console.ReadLine())
            {
               case "1.A":
                  XML.Handle();
                  break;
               case "1.B":
                  HandleCSVOrXLSX();
                  break;
               case "2":
                  Vaccine_Connect_.ViewingOptions();
                  break;
               case "3":
                  // Handle Privacy
                  break;
               case "4":
                  // Handle System
                  break;
               case "5":

                  break;
               case "6":
                  Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
                  string exitChoice = Console.ReadLine()?.ToLower();
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
      }

      private static void HandleCSVOrXLSX()
      {
         Console.WriteLine("Enter the path to the CSV or XLSX file:");
         string filePath = Console.ReadLine();

         if (File.Exists(filePath))
         {
            if (filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            {
               HandleCSV(filePath);
            }
            else if (filePath.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
               HandleXLSX(filePath);
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

      private static void HandleCSV(string filePath)
      {
         using (var reader = new StreamReader(filePath))
         {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               Console.WriteLine(line);
            }
         }
      }

      private static void HandleXLSX(string filePath)
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
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.