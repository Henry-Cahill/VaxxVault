using System;

namespace VaxxVault
{
   // Define a class to store and manage health-related data
   internal class Data
   {
      // Public properties for visibility outside the class
      public string  FirstName      { get; private set; }
      public string  LastName       { get; private set; }
      public string  Gender         { get; private set; }
      public int     Age            { get; private set; }
      public int     CurrentYear    { get; private set; }
      public int     HeightInInches { get; private set; }
      public int     WeightInPounds { get; private set; }
      public int     Month          { get; private set; }
      public int     Day            { get; private set; }
      public int     Year           { get; private set; }

      // Private instance variables for internal calculations
      private int maxHeartRate;
      private double minHighHeartRate;
      private double minLowHeartRate;
      private double bmi;

      // Constructor to initialize the object
      public Data(string firstName, string lastName, int age, string gender, int currentYear, int heightInInches, int weightInPounds, int month, int day, int year)
      {
         FirstName = firstName;
         LastName = lastName;
         Age = age > 0 ? age : throw new ArgumentOutOfRangeException(nameof(age), "Age must be greater than 0");
         Gender = gender;
         CurrentYear = currentYear > 0 ? currentYear : throw new ArgumentOutOfRangeException(nameof(currentYear), "Year must be greater than 0");
         HeightInInches = heightInInches > 0 ? heightInInches : throw new ArgumentOutOfRangeException(nameof(heightInInches), "Height must be greater than 0");
         WeightInPounds = weightInPounds > 0 ? weightInPounds : throw new ArgumentOutOfRangeException(nameof(weightInPounds), "Weight must be greater than 0");
         Month = month is >= 1 and <= 12 ? month : throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
         Day = day is >= 1 and <= 31 ? day : throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31");
         Year = year > 0 ? year : throw new ArgumentOutOfRangeException(nameof(year), "Year must be greater than 0");

         CalculateAge();
         CalculateHeartRates();
         CalculateBMI();
      }

      // Method to calculate the age based on current year and year of birth
      private void CalculateAge() => Age = CurrentYear - Year;

      // Method to calculate heart rate-related values
      private void CalculateHeartRates()
      {
         if (Age > 0)
         {
            maxHeartRate = 220 - Age;
            minHighHeartRate = maxHeartRate * 0.85;
            minLowHeartRate = maxHeartRate * 0.5;
         }
      }

      // Method to calculate the BMI (Body Mass Index)
      private void CalculateBMI()
      {
         if (HeightInInches > 0 && WeightInPounds > 0)
         {
            bmi = (WeightInPounds * 703) / Math.Pow(HeightInInches, 2);
         }
      }

      // Method to display the date in MM/DD/YYYY format
      public void DisplayDate() => Console.WriteLine($"{Month:D2}/{Day:D2}/{Year}");

      // Method to display the calculated heart rate information
      public void DisplayHeartRates()
      {
         Console.WriteLine($"Max Heart Rate: {maxHeartRate}");
         Console.WriteLine($"Min High Heart Rate: {minHighHeartRate}");
         Console.WriteLine($"Min Low Heart Rate: {minLowHeartRate}");
      }

      // Method to display the calculated BMI value
      public void DisplayBMI() => Console.WriteLine($"BMI: {bmi:F2}");
   } //End Class Data
}