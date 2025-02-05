using System;
using VaxxVault_V0002.Dir.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.JE;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.JE;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.Switchs_
{
   internal class HandleJE
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
               Vaccine_JER.ReviewXml();
               break;
            case "Drop":
               Vaccine_JED.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_JEL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}




