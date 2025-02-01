using System;
using System.Diagnostics;

namespace VaxxVault_V0002.Dir.Python_
{
   public class Vaccine_Py_DF
   {
      public static void Python()
      {
         // Path to the Python executable
         string pythonExePath = @"A:\New.New\Python3.9.13\python.exe";

         // Paths to the Python scripts
         string[] scriptPaths = new string[]
         {
                @"A:\New.New\VaxxVault\Dir\Python_\Python3_DataFrame.py"
         };

         foreach (string scriptPath in scriptPaths)
         {
            // Create a new process to run the Python script
            ProcessStartInfo start = new ProcessStartInfo
            {
               FileName = pythonExePath,
               Arguments = scriptPath,
               UseShellExecute = false,
               RedirectStandardOutput = true,
               RedirectStandardError = true,
               CreateNoWindow = true
            };

            using (Process process = Process.Start(start))
            {
               // Read the standard output of the Python script
               using (System.IO.StreamReader reader = process.StandardOutput)
               {
                  string result = reader.ReadToEnd();
                  Console.WriteLine(result);
               }

               // Read the standard error of the Python script (if any)
               using (System.IO.StreamReader reader = process.StandardError)
               {
                  string error = reader.ReadToEnd();
                  if (!string.IsNullOrEmpty(error))
                  {
                     Console.WriteLine("Error: " + error);
                  }
               }

               // Wait for the process to exit
               process.WaitForExit();
            }
         }
      }
   }
}

//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
