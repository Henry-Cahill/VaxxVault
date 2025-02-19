using System;
using System.IO;
using Xunit;
using VaxxVault_V0004.Dir.Main_;

namespace VaxxVault_V0004.Tests
{
   /// <summary>
   /// Contains unit tests for the CheckerboardGenerator class.
   /// </summary>
   public class CheckerboardGeneratorTests
   {
      /// <summary>
      /// Tests that the GenerateCheckerboard method prints the expected pattern.
      /// </summary>
      [Fact]
      public void GenerateCheckerboard_PrintsExpectedPattern()
      {
         // Arrange
         var expectedOutput =
             "* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *";

         var stringWriter = new StringWriter();
         Console.SetOut(stringWriter);
         // Act
         CheckerboardGenerator.GenerateCheckerboard();
         var actualOutput = stringWriter.ToString();
         // Assert
         Assert.Equal(expectedOutput, actualOutput);
         // Reset the console output
         Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
         Console.SetIn(new StreamReader(Console.OpenStandardInput()));
         Console.SetOut(stringWriter);
         stringWriter.Close();
         stringWriter.Dispose();
         stringWriter = null;
         GC.Collect();
         GC.WaitForPendingFinalizers();
      }
   }
}
