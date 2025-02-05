using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_
{
   internal class Vaccine_RubellaR
   {
      public static void ReviewXml()
      {
         // Prompt user to choose a version
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();

         if (string.IsNullOrEmpty(version))
         {
            version = "4.60";
         }

         string filePath = version switch
         {
            "4.60" => @"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData- Rubella-508.xml",
            "4.59" => @"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData- Rubella-508.xml",
            "4.58" => @"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData- Rubella-508.xml",
            "4.57" => @"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData- Rubella-508.xml",
            _ => null
         };

         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid version selected.");
            return;
         }

         // Load the XML file
         if (File.Exists(filePath))
         {
            try
            {
               XDocument xmlDoc = XDocument.Load(filePath);
               var elements = xmlDoc.Descendants("antigenSupportingData");

               foreach (var element in elements)
               {
                  Console.WriteLine(element);
               }
            }
            catch (Exception ex)
            {
               Console.WriteLine("An error occurred while loading the XML file: " + ex.Message);
            }
         }
         else
         {
            Console.WriteLine("File not found: " + filePath);
         }
      }
   }
}
