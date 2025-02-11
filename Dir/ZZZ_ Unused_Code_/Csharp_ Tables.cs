using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir.Archive_
{
   class Age
   {
      private static SqlConnection GetSqlConnection(string connectionName = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False", SqlCredential? credentials = null)
      {
         string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
         return credentials != null ? new SqlConnection(connectionString, credentials) : new SqlConnection(connectionString);
      }

      public static void Select_All()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Age, Absolute_Minimum_Age, Minimum_Age, Earliest_Recommended_Age, Latest_Recommended_Age, Maximum_Age, Effective_Date, Cessation_Date FROM AGE";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               SqlCommand command = new SqlCommand(query, connection);
               connection.Open();
               Console.WriteLine("\nConnection opened successfully.\n");
               SqlDataReader reader = command.ExecuteReader();

               if (!reader.HasRows)
               {
                  Console.WriteLine("No data found in the CONDITIONAL_SKIP table.");
                  return;
               }

               // Define attribute names
               List<string> attributeNames = new List<string>
                  {
                     "Age", "Absolute_Minimum_Age", "Minimum_Age", "Earliest_Recommended_Age",
                     "Latest_Recommended_Age", "Maximum_Age", "Effective_Date", "Cessation_Date"
                  };

               // Calculate number of rows
               int rowCount = 0;
               while (reader.Read())
               {
                  rowCount++;
               }

               // Set reader back to the beginning
               reader.Close();
               reader = command.ExecuteReader();

               // Print headers
               Console.Write("Attribute".PadRight(20));
               for (int i = 1; i <= rowCount; i++)
               {
                  Console.Write($"Row_{i}".PadRight(20));
               }
               Console.WriteLine();

               // Print divider line
               Console.WriteLine(new string('-', 20 * (rowCount + 1)));  // Adjust multiplier as needed for spacing

               // Print data under headers
               string[][] data = new string[attributeNames.Count][];

               for (int i = 0; i < attributeNames.Count; i++)
               {
                  data[i] = new string[rowCount];
               }

               int row = 0;
               while (reader.Read())
               {
                  for (int i = 0; i < attributeNames.Count; i++)
                  {
                     data[i][row] = reader[attributeNames[i]]?.ToString() ?? string.Empty;
                  }
                  row++;
               }

               for (int i = 0; i < attributeNames.Count; i++)
               {
                  Console.Write(attributeNames[i].PadRight(20));
                  for (int j = 0; j < rowCount; j++)
                  {
                     Console.Write(data[i][j].PadRight(20));
                  }
                  Console.WriteLine();
               }

               reader.Close();
               Console.WriteLine("\nQuery executed successfully.");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine("An error occurred: " + ex.Message);
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 