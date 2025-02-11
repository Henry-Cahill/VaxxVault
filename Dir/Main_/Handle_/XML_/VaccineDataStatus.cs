using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VaxxVault_V0003.Dir.Main_.Handle_.XML_
{
   /// <summary>
   /// Provides methods to handle the vaccine data status.
   /// </summary>
   internal static class VaccineDataStatus
   {
      private static readonly Dictionary<string, bool> vaccineStatuses = new()
        {
            { "Cholera", false },
            { "Covid19", false },
            { "Dengue", false },
            { "Diphtheria", false },
            { "Ebola", false },
            { "HepA", false },
            { "HepB", false },
            { "Hib", false },
            { "HPV", false },
            { "Influenza", false },
            { "JE", false },
            { "Measles", false },
            { "Meningococcal_B", false },
            { "Meningococcal", false },
            { "Mumps", false },
            { "Orthopoxvirus", false },
            { "Pertussis", false },
            { "Pneumococcal", false },
            { "Polio", false },
            { "Rabies", false },
            { "Rotavirus", false },
            { "RSV", false },
            { "Rubella", false },
            { "TBE", false },
            { "Tetanus", false },
            { "Typhoid", false },
            { "Varicella", false },
            { "YF", false },
            { "Zoster", false }
        };

      /// <summary>
      /// Gets the status of a specific vaccine.
      /// </summary>
      /// <param name="vaccineName">The name of the vaccine.</param>
      /// <returns>The status of the vaccine.</returns>
      public static bool GetVaccineStatus(string vaccineName)
      {
         return vaccineStatuses.TryGetValue(vaccineName, out bool status) && status;
      }

      /// <summary>
      /// Loads the data status for all vaccines asynchronously.
      /// </summary>
      public static async Task LoadDataStatusAsync()
      {
         var vaccineQueries = new Dictionary<string, string>
            {
                { "Cholera", "SELECT Id FROM VaccineData WHERE Id = 1;" },
                { "Covid19", "SELECT Id FROM VaccineData WHERE Id = 2;" },
                { "Dengue", "SELECT Id FROM VaccineData WHERE Id = 3;" },
                { "Diphtheria", "SELECT Id FROM VaccineData WHERE Id = 4;" },
                { "Ebola", "SELECT Id FROM VaccineData WHERE Id = 5;" },
                { "HepA", "SELECT Id FROM VaccineData WHERE Id = 6;" },
                { "HepB", "SELECT Id FROM VaccineData WHERE Id = 7;" },
                { "Hib", "SELECT Id FROM VaccineData WHERE Id = 8;" },
                { "HPV", "SELECT Id FROM VaccineData WHERE Id = 9;" },
                { "Influenza", "SELECT Id FROM VaccineData WHERE Id = 10;" },
                { "JE", "SELECT Id FROM VaccineData WHERE Id = 11;" },
                { "Measles", "SELECT Id FROM VaccineData WHERE Id = 12;" },
                { "Meningococcal_B", "SELECT Id FROM VaccineData WHERE Id = 13;" },
                { "Meningococcal", "SELECT Id FROM VaccineData WHERE Id = 14;" },
                { "Mumps", "SELECT Id FROM VaccineData WHERE Id = 15;" },
                { "Orthopoxvirus", "SELECT Id FROM VaccineData WHERE Id = 16;" },
                { "Pertussis", "SELECT Id FROM VaccineData WHERE Id = 17;" },
                { "Pneumococcal", "SELECT Id FROM VaccineData WHERE Id = 18;" },
                { "Polio", "SELECT Id FROM VaccineData WHERE Id = 19;" },
                { "Rabies", "SELECT Id FROM VaccineData WHERE Id = 20;" },
                { "Rotavirus", "SELECT Id FROM VaccineData WHERE Id = 21;" },
                { "RSV", "SELECT Id FROM VaccineData WHERE Id = 22;" },
                { "Rubella", "SELECT Id FROM VaccineData WHERE Id = 23;" },
                { "TBE", "SELECT Id FROM VaccineData WHERE Id = 24;" },
                { "Tetanus", "SELECT Id FROM VaccineData WHERE Id = 25;" },
                { "Typhoid", "SELECT Id FROM VaccineData WHERE Id = 26;" },
                { "Varicella", "SELECT Id FROM VaccineData WHERE Id = 27;" },
                { "YF", "SELECT Id FROM VaccineData WHERE Id = 28;" },
                { "Zoster", "SELECT Id FROM VaccineData WHERE Id = 29;" }
            };

         foreach (var vaccine in vaccineQueries)
         {
            vaccineStatuses[vaccine.Key] = await DatabaseHelper.CheckDataStatusAsync(vaccine.Value);
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 