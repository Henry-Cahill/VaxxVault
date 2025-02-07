using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Handle_.Switchs_;

namespace VaxxVault_V0003.Dir.Main_.Handle_.XML_
{
   internal static class MainMenu
   {
      public static void Handle()
      {
         VaccineDataStatus.LoadDataStatus();
         bool keepRunning = true;

         while (keepRunning)
         {
            VaccineDataStatus.LoadDataStatus();

            Console.WriteLine("Select One of the Following Options:");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("       Options        |  Loaded  |                      |\n" +
                              "------------------------------------------------------------------\n" +
                             $" -A.  Review ALL      |   N/A    | -14. Meningococcal   |  {VaccineDataStatus.Meningococcal}\n" +
                             $" -B.  Drop ALL        |   N/A    | -15. Mumps           |  {VaccineDataStatus.Mumps}\n" +
                             $" -C.  Load ALL        |   N/A    | -16. Orthopoxvirus   |  {VaccineDataStatus.Orthopoxvirus}\n" +
                             $" -1.  Cholera         |   {VaccineDataStatus.Cholera}   | -17. Pertussis       |  {VaccineDataStatus.Pertussis}\n" +
                             $" -2.  Covid19         |   {VaccineDataStatus.Covid19}   | -18. Pneumococcal    |  {VaccineDataStatus.Pneumococcal}\n" +
                             $" -3.  Dengue          |   {VaccineDataStatus.Dengue}   | -19. Polio           |  {VaccineDataStatus.Polio}\n" +
                             $" -4.  Diphtheria      |   {VaccineDataStatus.Diphtheria}   | -20. Rabies          |  {VaccineDataStatus.Rabies}\n" +
                             $" -5.  Ebola           |   {VaccineDataStatus.Ebola}   | -21. Rotavirus       |  {VaccineDataStatus.Rotavirus}\n" +
                             $" -6.  HepA            |   {VaccineDataStatus.HepA}   | -22. RSV             |  {VaccineDataStatus.RSV}\n" +
                             $" -7.  HepB            |   {VaccineDataStatus.HepB}   | -23. Rubella         |  {VaccineDataStatus.Rubella}\n" +
                             $" -8.  Hib             |   {VaccineDataStatus.Hib}   | -24. TBE             |  {VaccineDataStatus.TBE}\n" +
                             $" -9.  HPV             |   {VaccineDataStatus.HPV}   | -25. Tetanus         |  {VaccineDataStatus.Tetanus}\n" +
                             $" -10. Influenza       |   {VaccineDataStatus.Influenza}   | -26. Typhoid         |  {VaccineDataStatus.Typhoid}\n" +
                             $" -11. JE              |   {VaccineDataStatus.JE}   | -27. Varicella       |  {VaccineDataStatus.Varicella}\n" +
                             $" -12. Measles         |   {VaccineDataStatus.Measles}   | -28. YF              |  {VaccineDataStatus.YF}\n" +
                             $" -13. Meningococcal B |   {VaccineDataStatus.Meningococcal_B}   | -29. Zoster          |  {VaccineDataStatus.Zoster}\n" +
                              "                      |          | -30. Exit            |   N/A\n");

            switch (Console.ReadLine())
            {
               case "A":
                  ReviewAll.Execute();
                  break;
               case "B":
                  DropAll.Execute();
                  break;
               case "C":
                  LoadAll.Execute();
                  break;
               case "1":
                  HandleCholera.Execute();
                  break;
               case "2":
                  HandleCovid19.Execute();
                  break;
               case "3":
                  HandleDengue.Execute();
                  break;
               case "4":
                  HandleDiphtheria.Execute();
                  break;
               case "5":
                  HandleEbola.Execute();
                  break;
               case "6":
                  HandleHepA.Execute();
                  break;
               case "7":
                  HandleHepB.Execute();
                  break;
               case "8":
                  HandleHib.Execute();
                  break;
               case "9":
                  HandleHPV.Execute();
                  break;
               case "10":
                  HandleInfluenza.Execute();
                  break;
               case "11":
                  HandleJE.Execute();
                  break;
               case "12":
                  HandleMeasles.Execute();
                  break;
               case "13":
                  HandleMeningococcalB.Execute();
                  break;
               case "14":
                  HandleMeningococcal.Execute();
                  break;
               case "15":
                  HandleMumps.Execute();
                  break;
               case "16":
                  HandleOrthopoxvirus.Execute();
                  break;
               case "17":
                  HandlePertussis.Execute();
                  break;
               case "18":
                  HandlePneumococcal.Execute();
                  break;
               case "19":
                  HandlePolio.Execute();
                  break;
               case "20":
                  HandleRabies.Execute();
                  break;
               case "21":
                  HandleRotavirus.Execute();
                  break;
               case "22":
                  HandleRSV.Execute();
                  break;
               case "23":
                  HandleRubella.Execute();
                  break;
               case "24":
                  HandleTBE.Execute();
                  break;
               case "25":
                  HandleTetanus.Execute();
                  break;
               case "26":
                  HandleTyphoid.Execute();
                  break;
               case "27":
                  HandleVaricella.Execute();
                  break;
               case "28":
                  HandleYF.Execute();
                  break;
               case "29":
                  HandleZoster.Execute();
                  break;
               case "30":
                  Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
                  string exitChoice = Console.ReadLine()?.ToLower();
                  if (exitChoice == "yes")
                  {
                     keepRunning = false;
                     Console.WriteLine("\nExiting the program.\n");
                  }
                  break;
               default:
                  Console.WriteLine("Invalid choice. Please select a valid option.");
                  break;
            }
         }
      }
   }
}
