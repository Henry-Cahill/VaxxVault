using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class LoadAll
   {
      private static readonly string[] namespaces = new[]
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

      public static void Execute()
      {
         try
         {
            var vaccineTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => namespaces.Contains(t.Namespace) && t.Name.EndsWith("Loader"))
                .ToList();

            Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
            string? version = Console.ReadLine();
            if (string.IsNullOrEmpty(version))
            {
               version = "4.60";
            }

            Parallel.ForEach(vaccineTypes, type =>
            {
               var method = type.GetMethod("InsertXmlDataIntoDatabase", BindingFlags.Public | BindingFlags.Static);
               if (method != null)
               {
                  try
                  {
                     method.Invoke(null, new object[] { version });
                     Console.WriteLine($"Successfully invoked InsertXmlDataIntoDatabase on {type.FullName}");
                  }
                  catch (Exception ex)
                  {
                     Console.WriteLine($"An error occurred while invoking {type.FullName}: {ex.Message}");
                     Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                  }
               }
               else
               {
                  Console.WriteLine($"No InsertXmlDataIntoDatabase method found on {type.FullName}");
               }
            });
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
