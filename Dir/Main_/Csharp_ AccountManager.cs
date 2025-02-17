using System;
using System.Threading.Tasks;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// Manages account-related processes for VaxxVault.
   /// </summary>
   public class AccountManager
   {
      /// <summary>
      /// Manages the account process by updating the username of the given account.
      /// </summary>
      /// <param name="vaxxVaultAccount">The account to be managed.</param>
      /// <param name="newUsername">The new username to be set.</param>
      public static void ManageAccount(Account vaxxVaultAccount, string newUsername)
      {
         if (vaxxVaultAccount == null)
         {
            throw new ArgumentNullException(nameof(vaxxVaultAccount), "Account cannot be null");
         }

         if (string.IsNullOrWhiteSpace(newUsername))
         {
            throw new ArgumentException("Username cannot be null or whitespace.", nameof(newUsername));
         }

         Console.WriteLine($"Initial Username is: {vaxxVaultAccount.Username}");

         vaxxVaultAccount.Username = newUsername;

         Console.WriteLine($"Updated Username is: {vaxxVaultAccount.Username}\n");
      }

      /// <summary>
      /// Gets the new username from the user.
      /// </summary>
      /// <returns>The new username entered by the user.</returns>
      public static string GetNewUsername()
      {
         Console.Write("Enter the Username: ");
         string? input = Console.ReadLine();
         return input ?? string.Empty;
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.