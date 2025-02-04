using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir.Handle
{
   /// <summary>
   /// Provides functionality to execute Python scripts.
   /// </summary>
   public static class PythonExecutor
   {
      private const string PythonScriptPath = @"A:\New.New\VaxxVault\VaxxVault_Pi\Python_\Main_\VaxxVault_Pi.py";

      /// <summary>
      /// Executes a Python script from a file.
      /// </summary>
      /// <param name="filePath">The path to the Python script file.</param>
      /// <returns>The output of the Python script.</returns>
      public static async Task<string> ExecuteScriptFromFileAsync(string filePath)
      {
         return await ExecutePythonCommandAsync($"\"{filePath}\"");
      }

      /// <summary>
      /// Executes a Python script from a string.
      /// </summary>
      /// <param name="script">The Python script as a string.</param>
      /// <returns>The output of the Python script.</returns>
      public static async Task<string> ExecuteScriptFromStringAsync(string script)
      {
         return await ExecutePythonCommandAsync($"-c \"{script}\"");
      }

      /// <summary>
      /// Executes the specific Python script located at A:\New.New\VaxxVault\VaxxVault_Pi\Python_\Main_\VaxxVault_Pi.py.
      /// </summary>
      /// <returns>The output of the Python script.</returns>
      public static async Task<string> ExecuteSpecificPythonScriptAsync()
      {
         return await ExecuteScriptFromFileAsync(PythonScriptPath);
      }

      /// <summary>
      /// Executes a Python command and returns the output.
      /// </summary>
      /// <param name="arguments">The arguments to pass to the Python interpreter.</param>
      /// <returns>The output of the Python command.</returns>
      private static async Task<string> ExecutePythonCommandAsync(string arguments)
      {
         try
         {
            using (Process process = new Process())
            {
               process.StartInfo.FileName = "python";
               process.StartInfo.Arguments = arguments;
               process.StartInfo.RedirectStandardOutput = true;
               process.StartInfo.RedirectStandardError = true;
               process.StartInfo.UseShellExecute = false;
               process.StartInfo.CreateNoWindow = true;

               process.Start();

               string output = await process.StandardOutput.ReadToEndAsync();
               string error = await process.StandardError.ReadToEndAsync();

               await process.WaitForExitAsync();

               if (!string.IsNullOrEmpty(error))
               {
                  throw new Exception($"Python error: {error}");
               }

               return output;
            }
         }
         catch (Exception ex)
         {
            throw new InvalidOperationException("Failed to execute Python script.", ex);
         }
      }
   }
}