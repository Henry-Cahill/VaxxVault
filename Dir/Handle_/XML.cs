using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Load_;
using VaxxVault_V0002.Dir.Review_;
using VaxxVault_V0002.Dir.Drop_;


namespace VaxxVault_V0002.Dir.Handle
{
   internal class XML
   {
      public static void Handle()
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
         switch (Console.ReadLine())
         {
            case "Review ALL":
               Vaccine_CholeraR.ReviewXml();
               Vaccine_Covid19R.ReviewXml();
               Vaccine_DengueR.ReviewXml();
               Vaccine_DiphtheriaR.ReviewXml();
               Vaccine_EbolaR.ReviewXml();
               Vaccine_HepAR.ReviewXml();
               Vaccine_HepBR.ReviewXml();
               Vaccine_HibR.ReviewXml();
               Vaccine_HPVR.ReviewXml();
               Vaccine_InfluenzaR.ReviewXml();
               Vaccine_JER.ReviewXml();
               Vaccine_MeaslesR.ReviewXml();
               Vaccine_MeningococcalBR.ReviewXml();
               Vaccine_MeningococcalR.ReviewXml();
               Vaccine_MumpsR.ReviewXml();
               Vaccine_OrthopoxvirusR.ReviewXml();
               Vaccine_PertussisR.ReviewXml();
               Vaccine_PneumococcalR.ReviewXml();
               Vaccine_PolioR.ReviewXml();
               Vaccine_RabiesR.ReviewXml();
               Vaccine_RotavirusR.ReviewXml();
               Vaccine_RSVR.ReviewXml();
               Vaccine_RubellaR.ReviewXml();
               Vaccine_TBER.ReviewXml();
               Vaccine_TetanusR.ReviewXml();
               Vaccine_TyphoidR.ReviewXml();
               Vaccine_VaricellaR.ReviewXml();
               Vaccine_YFR.ReviewXml();
               Vaccine_ZosterR.ReviewXml();
               break;
            case "Drop ALL":
               Vaccine_CholeraD.DeleteXmlDataInDatabase();
               Vaccine_Covid19D.DeleteXmlDataInDatabase();
               Vaccine_DengueD.DeleteXmlDataInDatabase();
               Vaccine_DiphtheriaD.DeleteXmlDataInDatabase();
               Vaccine_EbolaD.DeleteXmlDataInDatabase();
               Vaccine_HepAD.DeleteXmlDataInDatabase();
               Vaccine_HepBD.DeleteXmlDataInDatabase();
               Vaccine_HibD.DeleteXmlDataInDatabase();
               Vaccine_HPVD.DeleteXmlDataInDatabase();
               Vaccine_InfluenzaD.DeleteXmlDataInDatabase();
               Vaccine_JED.DeleteXmlDataInDatabase();
               Vaccine_MeaslesD.DeleteXmlDataInDatabase();
               Vaccine_MeningococcalBD.DeleteXmlDataInDatabase();
               Vaccine_MeningococcalD.DeleteXmlDataInDatabase();
               Vaccine_MumpsD.DeleteXmlDataInDatabase();
               Vaccine_OrthopoxvirusD.DeleteXmlDataInDatabase();
               Vaccine_PertussisD.DeleteXmlDataInDatabase();
               Vaccine_PneumococcalD.DeleteXmlDataInDatabase();
               Vaccine_PolioD.DeleteXmlDataInDatabase();
               Vaccine_RabiesD.DeleteXmlDataInDatabase();
               Vaccine_RotavirusD.DeleteXmlDataInDatabase();
               Vaccine_RSVD.DeleteXmlDataInDatabase();
               Vaccine_RubellaD.DeleteXmlDataInDatabase();
               Vaccine_TBED.DeleteXmlDataInDatabase();
               Vaccine_TetanusD.DeleteXmlDataInDatabase();
               Vaccine_TyphoidD.DeleteXmlDataInDatabase();
               Vaccine_VaricellaD.DeleteXmlDataInDatabase();
               Vaccine_YFD.DeleteXmlDataInDatabase();
               Vaccine_ZosterD.DeleteXmlDataInDatabase();
               break;
            case "Load ALL":
               Vaccine_CholeraL.InsertXmlDataIntoDatabase();
               Vaccine_Covid19L.InsertXmlDataIntoDatabase();
               Vaccine_DengueL.InsertXmlDataIntoDatabase();
               Vaccine_DiphtheriaL.InsertXmlDataIntoDatabase();
               Vaccine_EbolaL.InsertXmlDataIntoDatabase();
               Vaccine_HepAL.InsertXmlDataIntoDatabase();
               Vaccine_HepBL.InsertXmlDataIntoDatabase();
               Vaccine_HibL.InsertXmlDataIntoDatabase();
               Vaccine_HPVL.InsertXmlDataIntoDatabase();
               Vaccine_InfluenzaL.InsertXmlDataIntoDatabase();
               Vaccine_JEL.InsertXmlDataIntoDatabase();
               Vaccine_MeaslesL.InsertXmlDataIntoDatabase();
               Vaccine_MeningococcalBL.InsertXmlDataIntoDatabase();
               Vaccine_MeningococcalL.InsertXmlDataIntoDatabase();
               Vaccine_MumpsL.InsertXmlDataIntoDatabase();
               Vaccine_OrthopoxvirusL.InsertXmlDataIntoDatabase();
               Vaccine_PertussisL.InsertXmlDataIntoDatabase();
               Vaccine_PneumococcalL.InsertXmlDataIntoDatabase();
               Vaccine_PolioL.InsertXmlDataIntoDatabase();
               Vaccine_RabiesL.InsertXmlDataIntoDatabase();
               Vaccine_RotavirusL.InsertXmlDataIntoDatabase();
               Vaccine_RSVL.InsertXmlDataIntoDatabase();
               Vaccine_RubellaL.InsertXmlDataIntoDatabase();
               Vaccine_TBEL.InsertXmlDataIntoDatabase();
               Vaccine_TetanusL.InsertXmlDataIntoDatabase();
               Vaccine_TyphoidL.InsertXmlDataIntoDatabase();
               Vaccine_VaricellaL.InsertXmlDataIntoDatabase();
               Vaccine_YFL.InsertXmlDataIntoDatabase();
               Vaccine_ZosterL.InsertXmlDataIntoDatabase();
               break;
            case "Cholera":
               HandleCholera();
               break;
            case "Covid19":
               HandleCovid19();
               break;
            case "Dengue":
               HandleDengue();
               break;
            case "Diphtheria":
               HandleDiphtheria();
               break;
            case "Ebola":
               HandleEbola();
               break;
            case "HepA":
               HandleHepA();
               break;
            case "HepB":
               HandleHepB();
               break;
            case "Hib":
               HandleHib();
               break;
            case "HPV":
               HandleHPV();
               break;
            case "Influenza":
               HandleInfluenza();
               break;
            case "JE":
               HandleJE();
               break;
            case "Measles":
               HandleMeasles();
               break;
            case "Meningococcal B":
               HandleMeningococcalB();
               break;
            case "Meningococcal":
               HandleMeningococcal();
               break;
            case "Mumps":
               HandleMumps();
               break;
            case "Orthopoxvirus":
               HandleOrthopoxvirus();
               break;
            case "Pertussis":
               HandlePertussis();
               break;
            case "Pneumococcal":
               HandlePneumococcal();
               break;
            case "Polio":
               HandlePolio();
               break;
            case "Rabies":
               HandleRabies();
               break;
            case "Rotavirus":
               HandleRotavirus();
               break;
            case "RSV":
               HandleRSV();
               break;
            case "Rubella":
               HandleRubella();
               break;
            case "TBE":
               HandleTBE();
               break;
            case "Tetanus":
               HandleTetanus();
               break;
            case "Typhoid":
               HandleTyphoid();
               break;
            case "Varicella":
               HandleVaricella();
               break;
            case "YF":
               HandleYF();
               break;
            case "Zoster":
               HandleZoster();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleCholera()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_CholeraR.ReviewXml();
               break;
            case "Drop":
               Vaccine_CholeraD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_CholeraL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleCovid19()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_Covid19R.ReviewXml();
               break;
            case "Drop":
               Vaccine_Covid19D.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_Covid19L.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleDengue()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_DengueR.ReviewXml();
               break;
            case "Drop":
               Vaccine_DengueD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_DengueL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleDiphtheria()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_DiphtheriaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_DiphtheriaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_DiphtheriaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleEbola()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_EbolaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_EbolaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_EbolaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleHepA()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_HepAR.ReviewXml();
               break;
            case "Drop":
               Vaccine_HepAD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_HepAL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleHepB()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_HepBR.ReviewXml();
               break;
            case "Drop":
               Vaccine_HepBD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_HepBL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleHib()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_HibR.ReviewXml();
               break;
            case "Drop":
               Vaccine_HibD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_HibL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleHPV()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_HPVR.ReviewXml();
               break;
            case "Drop":
               Vaccine_HPVD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_HPVL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleInfluenza()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_InfluenzaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_InfluenzaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_InfluenzaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleJE()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_JER.ReviewXml();
               break;
            case "Drop":
               Vaccine_JED.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_JEL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleMeasles()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_MeaslesR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MeaslesD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MeaslesL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleMeningococcalB()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_MeningococcalR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MeningococcalD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MeningococcalL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleMeningococcal()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_MeningococcalR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MeningococcalD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MeningococcalL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleMumps()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_MumpsR.ReviewXml();
               break;
            case "Drop":
               Vaccine_MumpsD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_MumpsL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleOrthopoxvirus()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_OrthopoxvirusR.ReviewXml();
               break;
            case "Drop":
               Vaccine_OrthopoxvirusD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_OrthopoxvirusL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandlePertussis()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_PertussisR.ReviewXml();
               break;
            case "Drop":
               Vaccine_PertussisD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_PertussisL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandlePneumococcal()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_PneumococcalR.ReviewXml();
               break;
            case "Drop":
               Vaccine_JED.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_PneumococcalL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandlePolio()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_PolioR.ReviewXml();
               break;
            case "Drop":
               Vaccine_PolioD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_PolioL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleRabies()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_RabiesR.ReviewXml();
               break;
            case "Drop":
               Vaccine_RabiesD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_RabiesL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleRotavirus()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_RotavirusR.ReviewXml();
               break;
            case "Drop":
               Vaccine_RotavirusD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_RotavirusL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleRSV()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_RSVR.ReviewXml();
               break;
            case "Drop":
               Vaccine_RSVD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_RSVL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleRubella()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_RubellaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_RubellaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_RubellaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleTBE()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_TBER.ReviewXml();
               break;
            case "Drop":
               Vaccine_TBED.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_TBEL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleTetanus()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_TetanusR.ReviewXml();
               break;
            case "Drop":
               Vaccine_TetanusD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_TetanusL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleTyphoid()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_TyphoidR.ReviewXml();
               break;
            case "Drop":
               Vaccine_TyphoidD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_TyphoidL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleVaricella()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_VaricellaR.ReviewXml();
               break;
            case "Drop":
               Vaccine_VaricellaD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_VaricellaL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleYF()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_YFR.ReviewXml();
               break;
            case "Drop":
               Vaccine_YFD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_YFL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
      private static void HandleZoster()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("  - Review");
         Console.WriteLine("  - Drop");
         Console.WriteLine("  - Load");
         switch (Console.ReadLine())
         {
            case "Review":
               Vaccine_ZosterR.ReviewXml();
               break;
            case "Drop":
               Vaccine_ZosterD.DeleteXmlDataInDatabase();
               break;
            case "Load":
               Vaccine_ZosterL.InsertXmlDataIntoDatabase();
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
