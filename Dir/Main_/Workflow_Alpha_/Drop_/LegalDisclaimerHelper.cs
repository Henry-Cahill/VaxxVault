using System;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_
{
   internal static class LegalDisclaimerHelper
   {
      public static void DisplayLegalDisclaimer()
      {
         Console.WriteLine("LEGAL DISCLAIMER:");
         Console.WriteLine("By authorizing the execution of these commands, you acknowledge and agree that:");
         Console.WriteLine("1. You have the necessary permissions and authority to execute these commands.");
         Console.WriteLine("2. Executing these commands will modify the database, and you understand the consequences.");
         Console.WriteLine("3. You accept full responsibility for any changes made to the database.");
         Console.WriteLine("4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.");
         Console.WriteLine("5. You have reviewed and understand the commands that will be executed.");
         Console.WriteLine("Do you authorize the execution of these commands? (yes/no)");
      }
   }
}
