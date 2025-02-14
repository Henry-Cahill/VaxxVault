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
   /// Provides methods to get user authorization.
   /// </summary>
   internal static class UserAuthorizationHelper
   {
      /// <summary>
      /// Prompts the user for authorization and returns the result.
      /// </summary>
      /// <returns>True if the user authorizes, otherwise false.</returns>
      public static bool GetUserAuthorization()
      {
         Console.WriteLine("Do you authorize the execution of these commands? (yes/no)");
         string? response = Console.ReadLine();
         return response?.Trim().ToLower() == "yes";
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.