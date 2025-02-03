using System;
using VaxxVault_V0002.Dir.Load_;
using VaxxVault_V0002.Dir.Review_;
using VaxxVault_V0002.Dir.Drop_;

namespace VaxxVault_V0002.Dir.Handle
{
   internal class HandleYF
   {
      public static void Execute()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_YFR.ReviewXml();
               break;
            case "Drop":
               Vaccine_YFD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_YFL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}