using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Rubella
{
   internal class VaccineRubellaDrop
   {
      /// <summary>
      /// Deletes XML data in the database.
      /// </summary>
      /// <returns>A task that represents the asynchronous operation.</returns>
      public static async Task DeleteXmlDataInDatabase()
      {
         // Read connection string from file
         string connectionStringFilePath = "A:\\New.New\\VaxxVault\\Dir\\Config_\\connectionString.txt";
         string connectionString;

         try
         {
            connectionString = await File.ReadAllTextAsync(connectionStringFilePath).ConfigureAwait(false);
         }
         catch (IOException ex)
         {
            Console.WriteLine($"IO error while reading connection string: {ex.Message}");
            // Log exception
            return;
         }

         try
         {
            LegalDisclaimerHelper.DisplayLegalDisclaimer();
            if (!UserAuthorizationHelper.GetUserAuthorization())
            {
               Console.WriteLine("Authorization denied. Exiting...");
               return;
            }

            // Execute SQL command to drop a row
            await ExecuteDeleteCommandAsync(connectionString).ConfigureAwait(false);
         }
         catch (SqlException ex)
         {
            Console.WriteLine($"SQL error: {ex.Message}");
            // Log exception
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Log exception
         }

         Console.WriteLine("Reminder: Please load another version of the Rubella XML data before proceeding.");
      }

      /// <summary>
      /// Executes the SQL delete command asynchronously.
      /// </summary>
      /// <param name="connectionString">The connection string to the database.</param>
      /// <returns>A task that represents the asynchronous operation.</returns>
      private static async Task ExecuteDeleteCommandAsync(string connectionString)
      {
         const string query = "DELETE FROM VaccineData WHERE Id = @Id;";

         using (var connection = new SqlConnection(connectionString))
         using (var command = new SqlCommand(query, connection))
         {
            command.Parameters.AddWithValue("@Id", 23); // Example parameter value

            await connection.OpenAsync().ConfigureAwait(false);
            await command.ExecuteNonQueryAsync().ConfigureAwait(false);
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.