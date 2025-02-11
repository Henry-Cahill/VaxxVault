using System;

namespace VaxxVault_V0002.Dir.Main_
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
      public static void ManageAccount(Account vaxxVaultAccount)
      {
         if (vaxxVaultAccount == null)
         {
            throw new ArgumentNullException(nameof(vaxxVaultAccount), "Account cannot be null");
         }

         Console.WriteLine($"Initial Username is: {vaxxVaultAccount.Username}");

         Console.Write("Enter the Username: ");
         string? newUsername = Console.ReadLine();

         if (string.IsNullOrWhiteSpace(newUsername))
         {
            Console.WriteLine("Username cannot be null or whitespace.");
         }
         else
         {
            vaxxVaultAccount.Username = newUsername;
            Console.WriteLine($"Updated Username is: {vaxxVaultAccount.Username}\n");
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
