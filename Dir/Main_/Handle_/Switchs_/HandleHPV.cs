using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.HPV;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.HPV;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleHPV
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
               Vaccine_HPVR.ReviewXml();
               break;
            case "Drop":
               Vaccine_HPVD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_HPVL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}



