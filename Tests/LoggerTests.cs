using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using VaxxVault_V0004.Dir.Main_;

namespace VaxxVault_V0004.Tests
{
    public class LoggerTests : IDisposable
    {
        private const string TestLogFilePath = "test_log.txt";

        public LoggerTests()
        {
            // Set up before each test
            Logger.SetLogFilePath(TestLogFilePath);
            Logger.SetLogLevel(Logger.LogLevel.Info);
        }

        [Fact]
        public void SetLogFilePath_ShouldUpdateLogFilePath()
        {
            // Arrange
            string newLogFilePath = "new_log.txt";

            // Act
            Logger.SetLogFilePath(newLogFilePath);

            // Assert
            Assert.Equal(newLogFilePath, TestLogFilePath);
        }

        [Fact]
        public void SetLogLevel_ShouldUpdateLogLevel()
        {
            // Arrange
            Logger.LogLevel newLogLevel = Logger.LogLevel.Error;

            // Act
            Logger.SetLogLevel(newLogLevel);

            // Assert
            Assert.Equal(newLogLevel, Logger.LogLevel.Error);
        }

        [Fact]
        public async Task LogInfoAsync_ShouldLogInfoMessage()
        {
            // Arrange
            string message = "This is an info message";

            // Act
            await Logger.LogInfoAsync(message);

            // Assert
            string logContent = File.ReadAllText(TestLogFilePath);
            Assert.Contains("INFO", logContent);
            Assert.Contains(message, logContent);
        }

        [Fact]
        public async Task LogErrorAsync_ShouldLogErrorMessage()
        {
            // Arrange
            string message = "This is an error message";

            // Act
            await Logger.LogErrorAsync(message);

            // Assert
            string logContent = File.ReadAllText(TestLogFilePath);
            Assert.Contains("ERROR", logContent);
            Assert.Contains(message, logContent);
        }

        public void Dispose()
        {
            // Clean up after each test
            if (File.Exists(TestLogFilePath))
            {
                File.Delete(TestLogFilePath);
            }
        }
    }
}
