using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir
{
   class Conditional_Skip
   {
      private static SqlConnection GetSqlConnection(string connectionName = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False", SqlCredential credentials = null)
      {
         string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
         return credentials != null ? new SqlConnection(connectionString, credentials) : new SqlConnection(connectionString);
      }

      public static void Select_All()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval, Dose_Count, Dose_Count_Logic, Vaccine_Types, Series_Group FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
                "Dose_Count", "Dose_Count_Logic", "Vaccine_Types", "Series_Group"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute1()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip FROM CONDITIONAL_SKIP";

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

               // Define Attribute names
               List<string> attributeNames = new List<string>
               {
                "Conditional_Skip"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute2()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute3()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute4()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute5()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute6()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date",
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute7()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute8()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute9()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute10()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute11()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute12()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute13()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute14()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval, Dose_Count, Dose_Count_Logic, Vaccine_Types, Series_Group FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
                "Dose_Count", "Dose_Count_Logic", "Vaccine_Types", "Series_Group"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute15()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute16()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval, Dose_Count FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
                "Dose_Count"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute17()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval, Dose_Count, Dose_Count_Logic FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
                "Dose_Count", "Dose_Count_Logic"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
      public static void Attribute18()
      {
         try
         {
            string connectionString = "Data Source=HLC-Laptop\\SQLEXPRESS;Initial Catalog=Dev-CDSi;Integrated Security=True;Encrypt=False";
            string query = "SELECT Conditional_Skip, Skip_Context, Set_Logic, Set_ID, Description, Effective_Date, Cessation_Date, Condition_Logic, Condition_ID, Type, Start_Date, End_Date, Begin_Age, End_Age, Interval, Dose_Count, Dose_Count_Logic, Vaccine_Types FROM CONDITIONAL_SKIP";

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
                "Conditional_Skip", "Skip_Context", "Set_Logic", "Set_ID", "Description",
                "Effective_Date", "Cessation_Date", "Condition_Logic", "Condition_ID", "Type",
                "Start_Date", "End_Date", "Begin_Age", "End_Age", "Interval",
                "Dose_Count", "Dose_Count_Logic", "Vaccine_Types"
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
                     data[i][row] = reader[attributeNames[i]].ToString();
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
