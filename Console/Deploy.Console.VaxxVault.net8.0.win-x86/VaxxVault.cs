// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlClient;
using System.Security.Principal;

namespace VaxxVault
{
   class Program
   {
      /*
      *  a) Read the problem statement.
      *  b) Formulate the algorithm using pseudocode and top-down, stepwise refinement.
      *  c) Write a C# app.
      *  d) Test, debug and execute the C# app.
      *  e) Process three complete sets of data
      */

      //Initialization phase
      // initialize variables in declarations
      // ???

      //Processing phase
      // ???

      //Termination phase
      // ???

      static void Account(Account vaxxVaultAccount)
      {
         //display VaxxVaultAccount's initial name (there isn't one yet)
         Console.WriteLine($"Initial Username is: {vaxxVaultAccount.GetName()}");

         //prompt for and read the name , then put the name in the object
         Console.Write("Enter the Username: "); // Prompt
         string theName = Console.ReadLine(); // Read the name
         vaxxVaultAccount.SetName(theName); // put theName in the myAccount object

         // display the name stored in the VaxxVaultAccount object
         Console.WriteLine($"myVaxxVault's Username is: {vaxxVaultAccount.GetName()}\n");
      }


      static void Data(Data vaxxVaultData)
      {
         Console.WriteLine(
         "\n                               ░░░░░░░░░▄░░░░░░░░░░░░░░▄░░\r" +
         "\n                               ░░░░░░░░▌▒█░░░░░░░░░░░▄▀▒▌░\r" +
         "\n                               ░░░░░░░░▌▒▒█░░░░░░░░▄▀▒▒▒▐░\r" +
         "\n                               ░░░░░░░▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐░\r" +
         "\n                               ░░░░░▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐░\r" +
         "\n                               ░░░▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌░\r" +
         "\n                               ░░▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▐▒░\r" +
         "\n                               ░░▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒░\r" +
         "\n                               ░▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄\r" +
         "\n                               ░▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▐\r" +
         "\n                               ▌▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▌" +
         "\n");


      }

      //Main method begins execution of C# application
      static void Main(string[] args)
      {
         Data VaxxVaultData = new Data("","",0,"",0,0,0,0,0,0,0,0,0,0);

         Data(VaxxVaultData);

         // Create an Account Object and assign it to VaxxVaultAccount.
         Account VaxxVaultAccount = new Account();

         Account(VaxxVaultAccount);

         string connectionString = "Data Source=HLC-LAPTOP\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False"; // Replace with your actual connection string
         string query = "SELECT Age, Absolute_Minimum_Age, Minimum_Age, Earliest_Recommended_Age, Latest_Recommended_Age, Maximum_Age, Effective_Date, Cessation_Date FROM AGE"; // Replace with your actual query

         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            int[] columnWidths = { 10, 5, 15, 25 };
            Console.WriteLine($"{"Age".PadRight(columnWidths[2])}" +
               $"{"Absolute_Minimum_Age".PadRight(columnWidths[3])}" +
               $"{"Minimum_Age".PadRight(columnWidths[2])}" +
               $"{"Earliest_Recommended_Age".PadRight(columnWidths[3])}" +
               $"{"Latest_Recommended_Age".PadRight(columnWidths[3])}" +
               $"{"Maximum_Age".PadRight(columnWidths[2])}" +
               $"{"Effective_Date".PadRight(columnWidths[2])}" +
               $"{"Cessation_Date".PadRight(columnWidths[1])}");

            while (reader.Read())
            {
               Console.WriteLine($"{reader["Age"].ToString().PadRight(columnWidths[2])}" +
                  $"{reader["Absolute_Minimum_Age"].ToString().PadRight(columnWidths[3])}" +
                  $"{reader["Minimum_Age"].ToString().PadRight(columnWidths[2])}" +
                  $"{reader["Earliest_Recommended_Age"].ToString().PadRight(columnWidths[3])}" +
                  $"{reader["Latest_Recommended_Age"].ToString().PadRight(columnWidths[3])}" +
                  $"{reader["Maximum_Age"].ToString().PadRight(columnWidths[2])}" +
                  $"{reader["Effective_Date"].ToString().PadRight(columnWidths[2])}" +
                  $"{reader["Cessation_Date"].ToString().PadRight(columnWidths[1])}");

            }
            reader.Close();
         }

         Console.WriteLine("To Be Continued...");
         Console.ReadLine();

      }//end Main
   }//end class Program 
}