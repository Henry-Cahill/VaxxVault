using System;
using System.Linq;
using System.Reflection;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class ReviewAll
   {
      // The Execute method is responsible for finding and invoking the ReviewXml method
      // in all types within the VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_ namespace that end with 'Review'.
      public static void Execute()
      {
         try
         {
            // List of namespaces to search for types
            var namespaces = new[]
            {
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Zoster",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.YF",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Varicella",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Typhoid",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Tetanus",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.TBE",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Rubella",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.RSV",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Rotavirus",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Rabies",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Polio",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pneumococcal",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pertussis",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Orthopoxvirus",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Mumps",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.MeningococcalB",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Meningococcal",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Measles",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.JE",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Influenza",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.HPV",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Hib",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.HepB",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.HepA",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Ebola",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Diphtheria",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Dengue",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.COVID19",
               "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Cholera"
            };

            // Get all types in the current assembly that belong to the specified namespaces and end with 'Review'.
            var vaccineTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => namespaces.Contains(t.Namespace) && t.Name.EndsWith("Review"))
                .ToList();

            // Iterate through each type found.
            foreach (var type in vaccineTypes)
            {
               // Get the ReviewXml method from the type, if it exists.
               var method = type.GetMethod("ReviewXml", BindingFlags.Public | BindingFlags.Static);

               if (method != null)
               {
                  // Invoke the method if it was found.
                  method.Invoke(null, null);
                  Console.WriteLine($"Successfully invoked ReviewXml on {type.FullName}");
               }
               else
               {
                  Console.WriteLine($"No ReviewXml method found on {type.FullName}");
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 