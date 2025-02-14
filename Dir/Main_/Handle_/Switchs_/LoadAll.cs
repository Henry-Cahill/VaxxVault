using System;
using System.Linq;
using System.Reflection;

namespace VaxxVault_V0004.Dir.Main_.Handle_.Switchs_
{
   internal class LoadAll
   {
      // The Execute method is responsible for finding and invoking the InsertXmlDataIntoDatabase method
      // in all types within the VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Load_ namespace that end with 'Loader'.
      public static void Execute()
      {
         // Get all types in the current assembly that belong to the specified namespace and end with 'Loader'.
         var vaccineTypes = Assembly.GetExecutingAssembly()
             .GetTypes()
             .Where(t => t.Namespace == "VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Load_" && t.Name.EndsWith("Loader"))
             .ToList();

         // Iterate through each type found.
         foreach (var type in vaccineTypes)
         {
            // Get the InsertXmlDataIntoDatabase method from the type, if it exists.
            var method = type.GetMethod("InsertXmlDataIntoDatabase", BindingFlags.Public | BindingFlags.Static);

            // Invoke the method if it was found.
            method?.Invoke(null, null);
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 