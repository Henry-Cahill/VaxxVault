using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Ebola;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Ebola;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.Switchs_
{
   internal class HandleEbola
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
               Vaccine_EbolaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_EbolaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_EbolaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}

