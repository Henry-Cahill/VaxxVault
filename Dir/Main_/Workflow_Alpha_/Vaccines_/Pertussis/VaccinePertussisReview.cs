using System;
using System.IO;
using System.Xml.Linq;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.Pertussis
{
   internal class VaccinePertussisReview
   {
      public static void ReviewXml()
      {
         string version = GetVersionFromUser();
         string? filePath = GetFilePath(version);

         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid version selected.");
            return;
         }

         if (!File.Exists(filePath))
         {
            Console.WriteLine($"File not found: {filePath}");
            return;
         }

         LoadAndDisplayXml(filePath);
      }

      private static string GetVersionFromUser()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();
         return string.IsNullOrEmpty(version) ? "4.60" : version;
      }

      private static string? GetFilePath(string version)
      {
         return version switch
         {
            "4.60" => @"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData- Pertussis-508.xml",
            "4.59" => @"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData- Pertussis-508.xml",
            "4.58" => @"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData- Pertussis-508.xml",
            "4.57" => @"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData- Pertussis-508.xml",
            _ => null
         };
      }

      private static void LoadAndDisplayXml(string filePath)
      {
         try
         {
            using var stream = File.OpenRead(filePath);
            XDocument xmlDoc = XDocument.Load(stream);
            var elements = xmlDoc.Descendants("antigenSupportingData");

            foreach (var element in elements)
            {
               Console.WriteLine(element);
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"An error occurred while loading the XML file: {ex.Message}");
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.