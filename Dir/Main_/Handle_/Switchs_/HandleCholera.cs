using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Cholera;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Cholera;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleCholera
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
               Vaccine_CholeraR.ReviewXml();
               break;
            case "Drop":
               Vaccine_CholeraD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_CholeraL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
