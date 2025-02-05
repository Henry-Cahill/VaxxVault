using System;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_
{
   internal static class VersionHelper
   {
      public static string GetVersionFromUser()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();
         return string.IsNullOrEmpty(version) ? "4.60" : version;
      }
   }
}
