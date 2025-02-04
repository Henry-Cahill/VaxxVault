using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Handle;

namespace VaxxVault_V0002.Dir.Main_
{
   public class Vaccine_Main
   {
      /// <summary>
      /// Executes a Python script asynchronously in a new process.
      /// </summary>
      public static async Task ExecutePythonScriptAsync()
      {
         try
         {
            var startInfo = new ProcessStartInfo
            {
               FileName = "python",
               Arguments = @"A:\New.New\VaxxVault\VaxxVault_Pi\Python_\Main_\VaxxVault_Pi.py",
               UseShellExecute = true,  // Use shell execute to open in a new window
               RedirectStandardOutput = false,  // Do not redirect output
               RedirectStandardError = false,  // Do not redirect error
               CreateNoWindow = false  // Create a new window
            };

            using (var process = Process.Start(startInfo))
            {
               if (process != null)
               {
                  await process.WaitForExitAsync();
                  Console.WriteLine("Python script executed successfully.");
               }
               else
               {
                  Console.WriteLine("Failed to start Python process.");
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error executing Python script: {ex.Message}");
         }
      }

      public static async Task Main(string[] args)
      {
         if (args.Length > 0 && args[0].ToLower() == "python")
         {
            await ExecutePythonScriptAsync();
            return;
         }

         var commands = new Dictionary<string, Func<Task>>
            {
                { "maintenance", () => Task.Run(() => Maintenance.Handle()) },
                { "main", () => Task.Run(() => MainRails.HandleAnotherTask()) },
                { "python", ExecutePythonScriptAsync },
                { "exit", () => Task.Run(() => Console.WriteLine("Exiting application...")) }
            };

         while (true)
         {
            Console.WriteLine("Please enter an argument ('main', 'maintenance', 'python', 'exit'):");
            var input = Console.ReadLine()?.ToLower();

            if (input == "exit")
            {
               await commands[input]();
               return;
            }

            if (commands.ContainsKey(input))
            {
               await commands[input]();
            }
            else
            {
               Console.WriteLine("Invalid argument. Use 'main', 'maintenance', 'python', or 'exit'.");
            }
         }
      }
   }
}

// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.