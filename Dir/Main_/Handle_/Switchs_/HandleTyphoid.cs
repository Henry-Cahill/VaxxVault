using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Typhoid;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Typhoid;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleTyphoid
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
               Vaccine_TyphoidR.ReviewXml();
               break;
            case "Drop":
               Vaccine_TyphoidD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_TyphoidL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}