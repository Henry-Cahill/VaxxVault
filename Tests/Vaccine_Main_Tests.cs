using System;
using System.IO;
using System.Threading.Tasks;
using VaxxVault_V0004.Dir.Main_;
using Xunit;

namespace VaxxVault_V0004.Tests
{
   /// <summary>
   /// Contains unit tests for the Vaccine_Main class.
   /// </summary>
   public class Vaccine_Main_Tests
   {
      /// <summary>
      /// Tests that HandleCommand returns the expected result for given input.
      /// </summary>
      /// <param name="input">The command input string.</param>
      /// <param name="expected">The expected result of the command.</param>
      [Theory]
      [InlineData("main", false)]
      [InlineData("maintenance", false)]
      [InlineData("python", false)]
      [InlineData("exit", true)]
      public void HandleCommand_ShouldReturnExpectedResult(string input, bool expected)
      {
         // Act
         var result = Vaccine_Main.HandleCommand(input);

         // Assert
         Assert.Equal(expected, result);
      }

      /// <summary>
      /// Tests that HandleCommand does not throw an exception for given input.
      /// </summary>
      /// <param name="input">The command input string.</param>
      [Theory]
      [InlineData("main")]
      [InlineData("maintenance")]
      [InlineData("python")]
      [InlineData("exit")]
      public void HandleCommand_ShouldNotThrowException(string input)
      {
         // Act & Assert
         var exception = Record.Exception(() => Vaccine_Main.HandleCommand(input));
         Assert.Null(exception);
      }

      /// <summary>
      /// Tests that HandleCommand handles invalid input correctly.
      /// </summary>
      [Fact]
      public void HandleCommand_ShouldHandleInvalidInput()
      {
         // Arrange
         var invalidInput = "invalid";

         // Act
         var result = Vaccine_Main.HandleCommand(invalidInput);

         // Assert
         Assert.False(result);
      }
  
      /// <summary>
      /// Tests that HandleCommand returns true for the exit command.
      /// </summary>
      [Fact]
      public void HandleCommand_ExitCommand_ReturnsTrue()
      {
         // Arrange
         var input = "exit";

         // Act
         var result = Vaccine_Main.HandleCommand(input);

         // Assert
         Assert.True(result);
      }

      /// <summary>
      /// Tests that the main loop exits for the exit command.
      /// </summary>
      [Fact]
      public async Task Main_ExitInput_ExitsLoop()
      {
         // Arrange
         var input = "exit";
         var stringReader = new StringReader(input);
         Console.SetIn(stringReader);

         // Act
         var task = Task.Run(() => Vaccine_Main.Main(new string[0]));
         await Task.Delay(1000); // Wait for a second to simulate user input
         await task; // Ensure the task is completed
         task.Dispose();

         // Assert
         // No exception means the loop exited
      }
   }
}