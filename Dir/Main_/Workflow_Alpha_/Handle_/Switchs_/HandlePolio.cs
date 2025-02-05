using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Polio;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Polio;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.Switchs_
{
   internal class HandlePolio
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
               Vaccine_PolioR.ReviewXml();
               break;
            case "Drop":
               Vaccine_PolioD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_PolioL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
