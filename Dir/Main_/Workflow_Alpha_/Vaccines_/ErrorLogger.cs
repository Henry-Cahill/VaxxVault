using System;
using System.IO;

namespace VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_
{
   internal static class ErrorLogger
   {
      public static void LogError(Exception ex)
      {
         LogHelper.LogError(ex);
      }

      public static void LogError(FileNotFoundException ex)
      {
         LogHelper.LogError(ex);
      }
   }
}
