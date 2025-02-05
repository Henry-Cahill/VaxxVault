using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Mumps;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Mumps;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.Switchs_
{
   internal class HandleMumps
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
               Vaccine_MumpsR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MumpsD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MumpsL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}








