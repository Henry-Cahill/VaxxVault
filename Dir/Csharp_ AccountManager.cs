using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir
{
   public class AccountManager
   {
      // Method to manage the account process
      public static void ManageAccount(Account vaxxVaultAccount)
      {
         Console.WriteLine($"Initial Username is: {vaxxVaultAccount.GetName()}");

         Console.Write("Enter the Username: ");
         string theName = Console.ReadLine();
         vaxxVaultAccount.SetName(theName);

         Console.WriteLine($"myVaxxVault's Username is: {vaxxVaultAccount.GetName()}\n");
      }
   }
}

