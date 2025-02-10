using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Meningococcal;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Meningococcal;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleMeningococcal
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
               Vaccine_MeningococcalR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MeningococcalD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MeningococcalL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}







