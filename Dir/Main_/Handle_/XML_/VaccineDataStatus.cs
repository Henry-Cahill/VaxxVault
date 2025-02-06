namespace VaxxVault_V0003.Dir.Main_.Handle_.XML_
{
   internal static class VaccineDataStatus
   {
      public static bool Cholera { get; private set; }
      public static bool Covid19 { get; private set; }
      public static bool Dengue { get; private set; }
      public static bool Diphtheria { get; private set; }
      public static bool Ebola { get; private set; }
      public static bool HepA { get; private set; }
      public static bool HepB { get; private set; }
      public static bool Hib { get; private set; }
      public static bool HPV { get; private set; }
      public static bool Influenza { get; private set; }
      public static bool JE { get; private set; }
      public static bool Measles { get; private set; }
      public static bool Meningococcal_B { get; private set; }
      public static bool Meningococcal { get; private set; }
      public static bool Mumps { get; private set; }
      public static bool Orthopoxvirus { get; private set; }
      public static bool Pertussis { get; private set; }
      public static bool Pneumococcal { get; private set; }
      public static bool Polio { get; private set; }
      public static bool Rabies { get; private set; }
      public static bool Rotavirus { get; private set; }
      public static bool RSV { get; private set; }
      public static bool Rubella { get; private set; }
      public static bool TBE { get; private set; }
      public static bool Tetanus { get; private set; }
      public static bool Typhoid { get; private set; }
      public static bool Varicella { get; private set; }
      public static bool YF { get; private set; }
      public static bool Zoster { get; private set; }

      public static void LoadDataStatus()
      {
         Cholera = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 1;");
         Covid19 = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 2;");
         Dengue = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 3;");
         Diphtheria = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 4;");
         Ebola = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 5;");
         HepA = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 6;");
         HepB = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 7;");
         Hib = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 8;");
         HPV = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 9;");
         Influenza = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 10;");
         JE = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 11;");
         Measles = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 12;");
         Meningococcal_B = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 13;");
         Meningococcal = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 14;");
         Mumps = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 15;");
         Orthopoxvirus = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 16;");
         Pertussis = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 17;");
         Pneumococcal = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 18;");
         Polio = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 19;");
         Rabies = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 20;");
         Rotavirus = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 21;");
         RSV = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 22;");
         Rubella = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 23;");
         TBE = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 24;");
         Tetanus = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 25;");
         Typhoid = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 26;");
         Varicella = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 27;");
         YF = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 28;");
         Zoster = DatabaseHelper.CheckDataStatus("SELECT Id FROM VaccineData WHERE Id = 29;");
      }
   }
}
