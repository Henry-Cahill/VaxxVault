using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Load_;
using VaxxVault_V0002.Dir.Review_;
using VaxxVault_V0002.Dir.Drop_;
using System.Runtime.InteropServices;

namespace VaxxVault_V0002.Dir.Handle
{
   internal class XML
   {
      public static void Handle()
      {
         bool keepRunning = true;

         while (keepRunning)
         {
            Console.WriteLine("Select One of the Following Options:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("  -A.  Review ALL         -14. Meningococcal\n" +
                              "  -B.  Drop ALL           -15. Mumps\n" +
                              "  -C.  Load ALL           -16. Orthopoxvirus\n" +
                              "  -1.  Cholera            -17. Pertussis\n" +
                              "  -2.  Covid19            -18. Pneumococcal\n" +
                              "  -3.  Dengue             -19. Polio\n" +
                              "  -4.  Diphtheria         -20. Rabies\n" +
                              "  -5.  Ebola              -21. Rotavirus\n" +
                              "  -6.  HepA               -22. RSV\n" +
                              "  -7.  HepB               -23. Rubella\n" +
                              "  -8.  Hib                -24. TBE\n" +
                              "  -9.  HPV                -25. Tetanus\n" +
                              "  -10. Influenza          -26. Typhoid\n" +
                              "  -11. JE                 -27. Varicella\n" +
                              "  -12. Measles            -28. YF\n" +
                              "  -13. Meningococcal B    -29. Zoster\n\n");
            Console.WriteLine("  -30. Exit\n");

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

//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
