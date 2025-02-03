using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Main_;

namespace VaxxVault_V0002.Dir.Handle
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
            Console.WriteLine("   1. XML");
            Console.WriteLine("   2. Privacy");
            Console.WriteLine("   3. System");

            Console.WriteLine("   5. Exit");

            switch (Console.ReadLine())
            {
               case "1":
                  XML.Handle();
                  break;
               case "2":
                 
                  break;
               case "3":
                  // Handle Privacy
                  break;
               case "4":
                  // Handle System
                  break;
               case "5":
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
   }
}

//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
