using System;
using System.IO;

namespace VaxxVault_V0002.Dir.Handle
{
    public static class Logger
    {
        public static void LogInfo(StreamWriter logFile, string message)
        {
            logFile.WriteLine($"{DateTime.Now} - INFO - {message}");
        }

        public static void LogError(StreamWriter logFile, string message)
        {
            logFile.WriteLine($"{DateTime.Now} - ERROR - {message}");
        }
    }
}
