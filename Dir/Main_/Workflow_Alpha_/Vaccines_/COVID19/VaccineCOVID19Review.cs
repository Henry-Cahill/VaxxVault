using System;
using System.IO;
using System.Xml.Linq;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_.COVID19
{
   internal class VaccineCovid19Review
   {
      // Entry point for reviewing the XML file based on user-selected version
      public static void ReviewXml()
      {
         // Get the version from the user
         string version = GetVersionFromUser();
         // Get the file path based on the selected version
         string? filePath = GetFilePath(version);

         // Check if the file path is valid
         if (string.IsNullOrEmpty(filePath))
         {
            Console.WriteLine("Invalid version selected.");
            return;
         }

         // Check if the file exists at the specified path
         if (!File.Exists(filePath))
         {
            Console.WriteLine($"File not found: {filePath}");
            return;
         }

         // Load and display the XML content
         LoadAndDisplayXml(filePath);
      }

      // Prompts the user to select a version and returns the selected version
      private static string GetVersionFromUser()
      {
         Console.WriteLine("Please choose a version (4.60, 4.59, 4.58, 4.57) [default is 4.60]:");
         string? version = Console.ReadLine();
         return string.IsNullOrEmpty(version) ? "4.60" : version;
      }

      // Returns the file path corresponding to the selected version
      private static string? GetFilePath(string version)
      {
         return version switch
         {
            "4.60" => @"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData- COVID-19-508.xml",
            "4.59" => @"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData- COVID-19-508.xml",
            "4.58" => @"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData- COVID-19-508.xml",
            "4.57" => @"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData- COVID-19-508.xml",
            _ => null
         };
      }

      // Loads the XML file from the specified path and displays its content
      private static void LoadAndDisplayXml(string filePath)
      {
         try
         {
            // Open the file stream
            using var stream = File.OpenRead(filePath);
            // Load the XML document
            XDocument xmlDoc = XDocument.Load(stream);
            // Get the elements with the tag "antigenSupportingData"
            var elements = xmlDoc.Descendants("antigenSupportingData");

            // Display each element
            foreach (var element in elements)
            {
               Console.WriteLine(element);
            }
         }
         catch (Exception ex)
         {
            // Handle any errors that occur during file loading
            Console.WriteLine($"An error occurred while loading the XML file: {ex.Message}");
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 