using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Orthopoxvirus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Orthopoxvirus;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class HandleOrthopoxvirus
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
               Vaccine_OrthopoxvirusR.ReviewXml();
               break;
            case "Drop":
               Vaccine_OrthopoxvirusD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_OrthopoxvirusL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
