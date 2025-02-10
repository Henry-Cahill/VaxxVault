using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Rubella;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rubella;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleRubella
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
               Vaccine_RubellaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_RubellaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_RubellaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
