using System;
using VaxxVault_V0004.Dir.Main_;
using Xunit;

namespace VaxxVault_V0004.Tests
{
    public class DataTests
    {
        [Fact]
        public void Constructor_ValidParameters_ShouldInitializeProperties()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Doe";
            var age = 30;
            var gender = "Male";
            var currentYear = 2025;
            var heightInInches = 70;
            var weightInPounds = 150;
            var month = 2;
            var day = 18;
            var year = 1995;

            // Act
            var data = new Data(firstName, lastName, age, gender, currentYear, heightInInches, weightInPounds, month, day, year);

            // Assert
            Assert.Equal(firstName, data.FirstName);
            Assert.Equal(lastName, data.LastName);
            Assert.Equal(age, data.Age);
            Assert.Equal(gender, data.Gender);
            Assert.Equal(currentYear, data.CurrentYear);
            Assert.Equal(heightInInches, data.HeightInInches);
            Assert.Equal(weightInPounds, data.WeightInPounds);
            Assert.Equal(month, data.Month);
            Assert.Equal(day, data.Day);
            Assert.Equal(year, data.Year);
        }

        [Fact]
        public void CalculateAge_ShouldCalculateCorrectAge()
        {
            // Arrange
            var data = new Data("John", "Doe", 0, "Male", 2025, 70, 150, 2, 18, 1995);

            // Act
            data.CalculateAge();

            // Assert
            Assert.Equal(30, data.Age);
        }

        [Fact]
        public void CalculateHeartRates_ShouldCalculateCorrectHeartRates()
        {
            // Arrange
            var data = new Data("John", "Doe", 30, "Male", 2025, 70, 150, 2, 18, 1995);

            // Act
            data.CalculateHeartRates();

            // Assert
            // Use reflection to access private fields
            var maxHeartRate = (int)typeof(Data).GetField("_maxHeartRate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(data);
            var minHighHeartRate = (double)typeof(Data).GetField("_minHighHeartRate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(data);
            var minLowHeartRate = (double)typeof(Data).GetField("_minLowHeartRate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(data);

            Assert.Equal(190, maxHeartRate);
            Assert.Equal(161.5, minHighHeartRate);
            Assert.Equal(95, minLowHeartRate);
        }

        [Fact]
        public void CalculateBMI_ShouldCalculateCorrectBMI()
        {
            // Arrange
            var data = new Data("John", "Doe", 30, "Male", 2025, 70, 150, 2, 18, 1995);

            // Act
            data.CalculateBMI();

            // Assert
            // Use reflection to access private fields
            var bmi = (double)typeof(Data).GetField("_bmi", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(data);

            Assert.Equal(21.52, bmi, 2);
        }

        [Fact]
        public void DisplayDate_ShouldDisplayCorrectDate()
        {
            // Arrange
            var data = new Data("John", "Doe", 30, "Male", 2025, 70, 150, 2, 18, 1995);
            var expectedOutput = "02/18/1995\n";

            // Act & Assert
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            data.DisplayDate();
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void DisplayHeartRates_ShouldDisplayCorrectHeartRates()
        {
            // Arrange
            var data = new Data("John", "Doe", 30, "Male", 2025, 70, 150, 2, 18, 1995);
            data.CalculateHeartRates();
            var expectedOutput = "Max Heart Rate: 190\nMin High Heart Rate: 161.5\nMin Low Heart Rate: 95\n";

            // Act & Assert
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            data.DisplayHeartRates();
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void DisplayBMI_ShouldDisplayCorrectBMI()
        {
            // Arrange
            var data = new Data("John", "Doe", 30, "Male", 2025, 70, 150, 2, 18, 1995);
            data.CalculateBMI();
            var expectedOutput = "BMI: 21.52\n";

            // Act & Assert
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);
            data.DisplayBMI();
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}
