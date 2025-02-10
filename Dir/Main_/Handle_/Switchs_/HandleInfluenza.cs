using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Influenza;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Influenza;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleInfluenza
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
               Vaccine_InfluenzaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_InfluenzaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_InfluenzaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}




