using System;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_
{
   /// <summary>
   /// This class provides a legal disclaimer for the execution of commands in the VaxxVault application.
   /// </summary>
   /// <remarks>
   /// The legal disclaimer outlines the responsibilities and liabilities of the user when executing commands.
   /// </remarks>
   /// <summary>
   /// Provides methods to display legal disclaimers.
   /// </summary>
   internal static class LegalDisclaimerHelper
   {
      private const string LegalDisclaimer = @"
LEGAL DISCLAIMER:
By authorizing the execution of these commands, you acknowledge and agree that:
1. You have the necessary permissions and authority to execute these commands.
2. Executing these commands will modify the database, and you understand the consequences.
3. You accept full responsibility for any changes made to the database.
4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.
5. You have reviewed and understand the commands that will be executed.
Do you authorize the execution of these commands? (yes/no)";

      /// <summary>
      /// Displays the legal disclaimer to the console.
      /// </summary>
      public static void DisplayLegalDisclaimer()
      {
         Console.WriteLine(LegalDisclaimer);
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.