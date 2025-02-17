using System;
using Xunit;
using VaxxVault_V0004.Dir.Main_;

namespace VaxxVault_V0004.Tests
{
    public class MainRailsTests
    {
        [Fact]
        public void HandleAnotherTask_ShouldRunWithoutExceptions()
        {
            // Arrange & Act
            var exception = Record.Exception(() => MainRails.HandleAnotherTask());

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void Initialize_ShouldRunWithoutExceptions()
        {
            // Arrange & Act
            var exception = Record.Exception(() => typeof(MainRails)
                .GetMethod("Initialize", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, null));

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void DisplayMenu_ShouldRunWithoutExceptions()
        {
            // Arrange & Act
            var exception = Record.Exception(() => typeof(MainRails)
                .GetMethod("DisplayMenu", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, null));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("1", true)]
        [InlineData("2", true)]
        [InlineData("3", true)]
        [InlineData("4", true)]
        [InlineData("5", true)]
        [InlineData("6", true)]
        [InlineData("8", false)]
        [InlineData("invalid", true)]
        public void HandleMenuChoice_ShouldReturnExpectedResult(string mainChoice, bool expected)
        {
            // Arrange & Act
            var result = (bool)typeof(MainRails)
                .GetMethod("HandleMenuChoice", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, new object[] { mainChoice });

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DisplayCalculationsAndResults_ShouldRunWithoutExceptions()
        {
            // Arrange & Act
            var exception = Record.Exception(() => typeof(MainRails)
                .GetMethod("DisplayCalculationsAndResults", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, null));

            // Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData("yes", false)]
        [InlineData("no", true)]
        [InlineData("invalid", true)]
        public void ConfirmExit_ShouldReturnExpectedResult(string exitChoice, bool expected)
        {
            // Arrange
            var consoleInput = new System.IO.StringReader(exitChoice);
            Console.SetIn(consoleInput);

            // Act
            var result = (bool)typeof(MainRails)
                .GetMethod("ConfirmExit", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, null);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
