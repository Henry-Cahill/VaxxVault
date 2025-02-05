using System;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_
{
   internal static class UserAuthorizationHelper
   {
      public static bool GetUserAuthorization()
      {
         string response = Console.ReadLine();
         return response?.Trim().ToLower() == "yes";
      }
   }
}
