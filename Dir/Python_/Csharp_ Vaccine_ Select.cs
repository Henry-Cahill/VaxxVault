using System;
using System.Diagnostics;
using System.IO;
using VaxxVault_V0002.Dir.Handle;

namespace VaxxVault_V0002.Dir.Python_
{
   /// <summary>
   /// Class to handle the selection of vaccines using a Python script.
   /// </summary>
   public class Vaccine_Py_Select
   {
      private static readonly string logFilePath = "A:\\New.New\\VaxxVault\\Dir\\temp\\vaccine_select_csharp.txt";
      private static readonly string workingDirectory = "A:\\New.New\\VaxxVault\\Dir\\Python_\\";

      /// <summary>
      /// Executes the Python script for vaccine selection and logs the process.
      /// </summary>
      public static void Python()
      {
         try
         {
            EnsureLogDirectoryExists();

            using (StreamWriter logFile = File.AppendText(logFilePath))
            {
               try
               {
                  LogInfo(logFile, "Starting Vaccine Select process.");
                  Console.WriteLine("Starting Vaccine Select process.");

                  if (!Directory.Exists(workingDirectory))
                  {
                     LogError(logFile, $"Working directory does not exist: {workingDirectory}");
                     Console.WriteLine($"Working directory does not exist: {workingDirectory}");
                     return;
                  }

                  ExecutePythonScript(logFile);
               }
               catch (Exception ex)
               {
                  LogError(logFile, $"An unexpected error occurred: {ex.Message}");
                  logFile.WriteLine(ex.ToString());
                  Console.WriteLine($"An unexpected error occurred: {ex.Message}");
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Failed to create or write to log file: {ex.Message}");
         }
      }

      private static void EnsureLogDirectoryExists()
      {
         string logDirectory = Path.GetDirectoryName(logFilePath);
         if (!Directory.Exists(logDirectory))
         {
            Directory.CreateDirectory(logDirectory);
         }
      }

      private static void ExecutePythonScript(StreamWriter logFile)
      {
         ProcessStartInfo start = new ProcessStartInfo
         {
            FileName = "python",
            Arguments = "Python3_Vaccine_Select.py",
            WorkingDirectory = workingDirectory,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true
         };

         using (Process process = Process.Start(start))
         {
            if (process == null)
            {
               LogError(logFile, "Failed to start Python process.");
               Console.WriteLine("Failed to start Python process.");
               return;
            }

            string result = process.StandardOutput.ReadToEnd();
            LogInfo(logFile, $"Python script output: {result}");
            Console.WriteLine(result);

            string error = process.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(error))
            {
               LogError(logFile, $"Python script error: {error}");
               Console.WriteLine(error);
            }

            process.WaitForExit();
            LogInfo(logFile, $"Python process exited with code {process.ExitCode}.");
            Console.WriteLine($"Python process exited with code {process.ExitCode}.");
         }

         LogInfo(logFile, "Vaccine Select process completed.");
         Console.WriteLine("Vaccine Select process completed.");
      }

      private static void LogInfo(StreamWriter logFile, string message)
      {
         logFile.WriteLine($"{DateTime.Now} - INFO - {message}");
      }

      private static void LogError(StreamWriter logFile, string message)
      {
         logFile.WriteLine($"{DateTime.Now} - ERROR - {message}");
      }

      /// <summary>
      /// Another method to handle a different task.
      /// </summary>
      public static void AnotherTask()
      {
         // Initialization phase: Initialize variables, create instances, and prompt user for input.
         // Generate the checkboard pattern

         CheckerboardGenerator.GenerateCheckerboard();

         Account vaxxVaultAccount = new Account();
         AccountManager.ManageAccount(vaxxVaultAccount);

         Data vaxxVaultData = new Data("John", "Doe", 30, "Male", 2025, 70, 180, 1, 15, 1995);

         // Processing phase: Perform calculations and display results.
         vaxxVaultData.DisplayDate();
         vaxxVaultData.DisplayHeartRates();
         vaxxVaultData.DisplayBMI();

         // Termination phase: Provide options to view additional information or exit the program.
         bool keepRunning = true;

         while (keepRunning)
         {
            Console.WriteLine("\nSelect one of the Following Options:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("0. ");
            Console.WriteLine("1. View Seasonal Recommendation");
            Console.WriteLine("2. View Recurring Dose");
            Console.WriteLine("3. View Conditional Skip");
            Console.WriteLine("4. ");
            Console.WriteLine("5. View Age");
            Console.WriteLine("\nAdditional Selections:");
            Console.WriteLine("6. Calculations and Results");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Exit\n");

            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
               case "0":

                  break;

               case "1":
                  //HandleSeasonalRecommendation();
                  break;

               case "2":
                  //HandleRecurringDose();
                  break;

               case "3":
                  //HandleConditionalSkip();
                  break;

               case "4":
                  // Placeholder for future functionality
                  break;

               case "5":
                  Console.WriteLine("\nDisplaying Age Table");
                  // Age.Select_All();
                  break;

               case "6":
                  Console.WriteLine();
                  vaxxVaultData.DisplayDate();
                  vaxxVaultData.DisplayHeartRates();
                  vaxxVaultData.DisplayBMI();
                  break;

               case "8":
                  keepRunning = false;
                  Console.WriteLine("\nExiting the program.\n");
                  break;

               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
         // Generate the checkboard pattern
         CheckerboardGenerator.GenerateCheckerboard();
      }

      /// <summary>
      /// Main method to execute the appropriate method based on arguments.
      /// </summary>
      public static void Main(string[] args)
      {
         while (true)
         {
            Console.WriteLine("Please enter an argument ('main'):");
            Console.WriteLine("Type 'maintenance' to access the maintenance menu.");
            Console.WriteLine("Type 'python' to execute the Python scripts."); 
            string input = Console.ReadLine()?.ToLower();
            
            switch (input)
            {
               case "maintenance":
                  Maintenance.Handle();
                  break;
               case "python":
                  Python();
                  break;
               case "main":
                  AnotherTask();
                  break;
               default:
                  Console.WriteLine("Invalid argument. Use 'main'.");
                  continue;
            }
            break;
         }
         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
      }
   }
}

// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
