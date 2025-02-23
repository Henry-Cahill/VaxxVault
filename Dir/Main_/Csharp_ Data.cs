using System;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// Defines a class to store and manage health-related data.
   /// </summary>
   public class Data
   {
      /// <summary>
      /// Gets the first name of the individual.
      /// </summary>
      public string FirstName { get; private set; }

      /// <summary>
      /// Gets the last name of the individual.
      /// </summary>
      public string LastName { get; private set; }

      /// <summary>
      /// Gets the gender of the individual.
      /// </summary>
      public string Gender { get; private set; }

      /// <summary>
      /// Gets the age of the individual.
      /// </summary>
      public int Age { get; private set; }

      /// <summary>
      /// Gets the current year.
      /// </summary>
      public int CurrentYear { get; private set; }

      /// <summary>
      /// Gets the height of the individual in inches.
      /// </summary>
      public int HeightInInches { get; private set; }

      /// <summary>
      /// Gets the weight of the individual in pounds.
      /// </summary>
      public int WeightInPounds { get; private set; }

      /// <summary>
      /// Gets the month of birth of the individual.
      /// </summary>
      public int Month { get; private set; }

      /// <summary>
      /// Gets the day of birth of the individual.
      /// </summary>
      public int Day { get; private set; }

      /// <summary>
      /// Gets the year of birth of the individual.
      /// </summary>
      public int Year { get; private set; }

      // Private instance variables for internal calculations
      private int _maxHeartRate;
      private double _minHighHeartRate;
      private double _minLowHeartRate;
      private double _bmi;

      /// <summary>
      /// Constructor to initialize the object.
      /// </summary>
      public Data(string firstName, string lastName, int age, string gender, int currentYear, int heightInInches, int weightInPounds, int month, int day, int year)
      {
         FirstName = ValidateString(firstName, nameof(firstName));
         LastName = ValidateString(lastName, nameof(lastName));
         Age = ValidatePositiveInt(age, nameof(age));
         Gender = ValidateString(gender, nameof(gender));
         CurrentYear = ValidatePositiveInt(currentYear, nameof(currentYear));
         HeightInInches = ValidatePositiveInt(heightInInches, nameof(heightInInches));
         WeightInPounds = ValidatePositiveInt(weightInPounds, nameof(weightInPounds));
         Month = ValidateMonth(month);
         Day = ValidateDay(day);
         Year = ValidatePositiveInt(year, nameof(year));

         CalculateAge();
         CalculateHeartRates();
         CalculateBMI();
      }

      /// <summary>
      /// Method to calculate the age based on current year and year of birth.
      /// </summary>
      public void CalculateAge() => Age = CurrentYear - Year;

      /// <summary>
      /// Method to calculate heart rate-related values.
      /// </summary>
      public void CalculateHeartRates()
      {
         if (Age > 0)
         {
            _maxHeartRate = 220 - Age;
            _minHighHeartRate = _maxHeartRate * 0.85;
            _minLowHeartRate = _maxHeartRate * 0.5;
         }
      }

      /// <summary>
      /// Method to calculate the BMI (Body Mass Index).
      /// </summary>
      public void CalculateBMI()
      {
         if (HeightInInches > 0 && WeightInPounds > 0)
         {
            _bmi = WeightInPounds * 703 / Math.Pow(HeightInInches, 2);
         }
      }


      /// <summary>
      /// Method to display the date in MM/DD/YYYY format.
      /// </summary>
      public void DisplayDate() => Console.WriteLine($"{Month:D2}/{Day:D2}/{Year}");

      /// <summary>
      /// Method to display the calculated heart rate information.
      /// </summary>
      public void DisplayHeartRates()
      {
         Console.WriteLine($"Max Heart Rate: {_maxHeartRate}");
         Console.WriteLine($"Min High Heart Rate: {_minHighHeartRate}");
         Console.WriteLine($"Min Low Heart Rate: {_minLowHeartRate}");
      }

      /// <summary>
      /// Method to display the calculated BMI value.
      /// </summary>
      public void DisplayBMI()
      {
         if (_bmi > 0)
         {
            Console.WriteLine($"BMI: {_bmi:F2}");
         }
         else
         {
            Console.WriteLine("BMI is not calculated.");
         }
      }


      /// <summary>
      /// Validates that a string is not null or empty.
      /// </summary>
      public static string ValidateString(string value, string paramName)
      {
         return value ?? throw new ArgumentNullException(paramName, $"{paramName} cannot be null");
      }

      /// <summary>
      /// Validates that an integer is positive.
      /// </summary>
      public static int ValidatePositiveInt(int value, string paramName)
      {
         return value > 0 ? value : throw new ArgumentOutOfRangeException(paramName, $"{paramName} must be greater than 0");
      }

      /// <summary>
      /// Validates that the month is between 1 and 12.
      /// </summary>
      public static int ValidateMonth(int month)
      {
         return month is >= 1 and <= 12 ? month : throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
      }

      /// <summary>
      /// Validates that the day is between 1 and 31.
      /// </summary>
      public static int ValidateDay(int day)
      {
         return day is >= 1 and <= 31 ? day : throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31");
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.