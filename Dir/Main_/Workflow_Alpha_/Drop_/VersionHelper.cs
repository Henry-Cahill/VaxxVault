using System;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_
{
   /// <summary>
   /// Provides methods to get the version from the user.
   /// </summary>
   internal static class VersionHelper
   {
      private const string DefaultVersion = "4.60";
      private static readonly string[] AllowedVersions = { "4.60", "4.59", "4.58", "4.57" };

      /// <summary>
      /// Prompts the user to choose a version and returns the selected version.
      /// </summary>
      /// <returns>The selected version, or the default version if no valid input is provided.</returns>
      public static string GetVersionFromUser()
      {
         Console.WriteLine($"Please choose a version ({string.Join(", ", AllowedVersions)}) [default is {DefaultVersion}]:");
         string? version = Console.ReadLine()?.Trim();

         if (string.IsNullOrEmpty(version) || Array.IndexOf(AllowedVersions, version) < 0)
         {
            Console.WriteLine($"Invalid input. Defaulting to version {DefaultVersion}.");
            return DefaultVersion;
         }

         return version;
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.