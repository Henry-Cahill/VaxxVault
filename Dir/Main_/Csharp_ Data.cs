using System;

namespace VaxxVault_V0004.Dir.Main_
{
   // Define a class to store and manage health-related data
   internal class Data
   {
      // Public properties for visibility outside the class
      public string FirstName { get; private set; }
      public string LastName { get; private set; }
      public string Gender { get; private set; }
      public int Age { get; private set; }
      public int CurrentYear { get; private set; }
      public int HeightInInches { get; private set; }
      public int WeightInPounds { get; private set; }
      public int Month { get; private set; }
      public int Day { get; private set; }
      public int Year { get; private set; }

      // Private instance variables for internal calculations
      private int _maxHeartRate;
      private double _minHighHeartRate;
      private double _minLowHeartRate;
      private double _bmi;

      // Constructor to initialize the object
      public Data(string firstName, string lastName, int age, string gender, int currentYear, int heightInInches, int weightInPounds, int month, int day, int year)
      {
         FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "First name cannot be null");
         LastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "Last name cannot be null");
         Age = age > 0 ? age : throw new ArgumentOutOfRangeException(nameof(age), "Age must be greater than 0");
         Gender = gender ?? throw new ArgumentNullException(nameof(gender), "Gender cannot be null");
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
            _maxHeartRate = 220 - Age;
            _minHighHeartRate = _maxHeartRate * 0.85;
            _minLowHeartRate = _maxHeartRate * 0.5;
         }
      }

      // Method to calculate the BMI (Body Mass Index)
      private void CalculateBMI()
      {
         if (HeightInInches > 0 && WeightInPounds > 0)
         {
            _bmi = WeightInPounds * 703 / Math.Pow(HeightInInches, 2);
         }
      }

      // Method to display the date in MM/DD/YYYY format
      public void DisplayDate() => Console.WriteLine($"{Month:D2}/{Day:D2}/{Year}");

      // Method to display the calculated heart rate information
      public void DisplayHeartRates()
      {
         Console.WriteLine($"Max Heart Rate: {_maxHeartRate}");
         Console.WriteLine($"Min High Heart Rate: {_minHighHeartRate}");
         Console.WriteLine($"Min Low Heart Rate: {_minLowHeartRate}");
      }

      // Method to display the calculated BMI value
      public void DisplayBMI() => Console.WriteLine($"BMI: {_bmi:F2}");
   } // End Class Data
}

// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.