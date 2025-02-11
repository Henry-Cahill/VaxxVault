using System;
using System.Threading.Tasks;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Handle_.Switchs_;

namespace VaxxVault_V0003.Dir.Main_.Handle_.XML_
{
   /// <summary>
   /// Provides methods to handle the main menu.
   /// </summary>
   internal static class MainMenu
   {
      private const string ExitOption = "30";

      /// <summary>
      /// Handles the main menu operations.
      /// </summary>
      public static async Task Handle()
      {
         await VaccineDataStatus.LoadDataStatusAsync();
         bool keepRunning = true;

         while (keepRunning)
         {
            await VaccineDataStatus.LoadDataStatusAsync();
            DisplayMenu();

            string? choice = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(choice))
            {
               Console.WriteLine("Invalid choice. Please select a valid option.");
               continue;
            }

            if (choice == ExitOption)
            {
               if (await ConfirmExitAsync())
               {
                  keepRunning = false;
                  Console.WriteLine("\nExiting the program.\n");
               }
            }
            else
            {
               await HandleChoiceAsync(choice);
            }
         }
      }

      /// <summary>
      /// Displays the main menu.
      /// </summary>
      private static void DisplayMenu()
      {
         Console.WriteLine("       Options        |  Loaded  |                      |\n" +
                        "------------------------------------------------------------------\n" +
                       $" -A.  Review ALL      |   N/A    | -14. Meningococcal   |  {VaccineDataStatus.GetVaccineStatus("Meningococcal")}\n" +
                       $" -B.  Drop ALL        |   N/A    | -15. Mumps           |  {VaccineDataStatus.GetVaccineStatus("Mumps")}\n" +
                       $" -C.  Load ALL        |   N/A    | -16. Orthopoxvirus   |  {VaccineDataStatus.GetVaccineStatus("Orthopoxvirus")}\n" +
                       $" -1.  Cholera         |   {VaccineDataStatus.GetVaccineStatus("Cholera")}   | -17. Pertussis       |  {VaccineDataStatus.GetVaccineStatus("Pertussis")}\n" +
                       $" -2.  Covid19         |   {VaccineDataStatus.GetVaccineStatus("Covid19")}   | -18. Pneumococcal    |  {VaccineDataStatus.GetVaccineStatus("Pneumococcal")}\n" +
                       $" -3.  Dengue          |   {VaccineDataStatus.GetVaccineStatus("Dengue")}   | -19. Polio           |  {VaccineDataStatus.GetVaccineStatus("Polio")}\n" +
                       $" -4.  Diphtheria      |   {VaccineDataStatus.GetVaccineStatus("Diphtheria")}   | -20. Rabies          |  {VaccineDataStatus.GetVaccineStatus("Rabies")}\n" +
                       $" -5.  Ebola           |   {VaccineDataStatus.GetVaccineStatus("Ebola")}   | -21. Rotavirus       |  {VaccineDataStatus.GetVaccineStatus("Rotavirus")}\n" +
                       $" -6.  HepA            |   {VaccineDataStatus.GetVaccineStatus("HepA")}   | -22. RSV             |  {VaccineDataStatus.GetVaccineStatus("RSV")}\n" +
                       $" -7.  HepB            |   {VaccineDataStatus.GetVaccineStatus("HepB")}   | -23. Rubella         |  {VaccineDataStatus.GetVaccineStatus("Rubella")}\n" +
                       $" -8.  Hib             |   {VaccineDataStatus.GetVaccineStatus("Hib")}   | -24. TBE             |  {VaccineDataStatus.GetVaccineStatus("TBE")}\n" +
                       $" -9.  HPV             |   {VaccineDataStatus.GetVaccineStatus("HPV")}   | -25. Tetanus         |  {VaccineDataStatus.GetVaccineStatus("Tetanus")}\n" +
                       $" -10. Influenza       |   {VaccineDataStatus.GetVaccineStatus("Influenza")}   | -26. Typhoid         |  {VaccineDataStatus.GetVaccineStatus("Typhoid")}\n" +
                       $" -11. JE              |   {VaccineDataStatus.GetVaccineStatus("JE")}   | -27. Varicella       |  {VaccineDataStatus.GetVaccineStatus("Varicella")}\n" +
                       $" -12. Measles         |   {VaccineDataStatus.GetVaccineStatus("Measles")}   | -28. YF              |  {VaccineDataStatus.GetVaccineStatus("YF")}\n" +
                       $" -13. Meningococcal B |   {VaccineDataStatus.GetVaccineStatus("Meningococcal_B")}   | -29. Zoster          |  {VaccineDataStatus.GetVaccineStatus("Zoster")}\n" +
                        "                      |          | -30. Exit            |   N/A\n");
      }

      /// <summary>
      /// Handles the user's choice from the menu.
      /// </summary>
      /// <param name="choice">The user's choice.</param>
      private static async Task HandleChoiceAsync(string choice)
      {
         switch (choice)
         {
            case "A":
               await Task.Run(() => ReviewAll.Execute());
               break;
            case "B":
               await Task.Run(() => DropAll.Execute());
               break;
            case "C":
               await Task.Run(() => LoadAll.Execute());
               break;
            case "1":
               await Task.Run(() => HandleCholera.Execute());
               break;
            case "2":
               await Task.Run(() => HandleCovid19.Execute());
               break;
            case "3":
               await Task.Run(() => HandleDengue.Execute());
               break;
            case "4":
               await Task.Run(() => HandleDiphtheria.Execute());
               break;
            case "5":
               await Task.Run(() => HandleEbola.Execute());
               break;
            case "6":
               await Task.Run(() => HandleHepA.Execute());
               break;
            case "7":
               await Task.Run(() => HandleHepB.Execute());
               break;
            case "8":
               await Task.Run(() => HandleHib.Execute());
               break;
            case "9":
               await Task.Run(() => HandleHPV.Execute());
               break;
            case "10":
               await Task.Run(() => HandleInfluenza.Execute());
               break;
            case "11":
               await Task.Run(() => HandleJE.Execute());
               break;
            case "12":
               await Task.Run(() => HandleMeasles.Execute());
               break;
            case "13":
               await Task.Run(() => HandleMeningococcalB.Execute());
               break;
            case "14":
               await Task.Run(() => HandleMeningococcal.Execute());
               break;
            case "15":
               await Task.Run(() => HandleMumps.Execute());
               break;
            case "16":
               await Task.Run(() => HandleOrthopoxvirus.Execute());
               break;
            case "17":
               await Task.Run(() => HandlePertussis.Execute());
               break;
            case "18":
               await Task.Run(() => HandlePneumococcal.Execute());
               break;
            case "19":
               await Task.Run(() => HandlePolio.Execute());
               break;
            case "20":
               await Task.Run(() => HandleRabies.Execute());
               break;
            case "21":
               await Task.Run(() => HandleRotavirus.Execute());
               break;
            case "22":
               await Task.Run(() => HandleRSV.Execute());
               break;
            case "23":
               await Task.Run(() => HandleRubella.Execute());
               break;
            case "24":
               await Task.Run(() => HandleTBE.Execute());
               break;
            case "25":
               await Task.Run(() => HandleTetanus.Execute());
               break;
            case "26":
               await Task.Run(() => HandleTyphoid.Execute());
               break;
            case "27":
               await Task.Run(() => HandleVaricella.Execute());
               break;
            case "28":
               await Task.Run(() => HandleYF.Execute());
               break;
            case "29":
               await Task.Run(() => HandleZoster.Execute());
               break;
         }
      }

      /// <summary>
      /// Confirms if the user wants to exit the application.
      /// </summary>
      /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating if the user confirmed the exit.</returns>
      private static async Task<bool> ConfirmExitAsync()
      {
         Console.WriteLine("Do you really want to close VaxxVault? (yes/no)");
         string? exitChoice = (await Task.Run(() => Console.ReadLine()))?.ToLower();
         return exitChoice == "yes";
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 