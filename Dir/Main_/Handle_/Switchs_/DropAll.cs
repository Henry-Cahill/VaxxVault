using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Cholera;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.COVID19;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Dengue;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Diphtheria;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Ebola;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.HepA;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.HepB;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Hib;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.HPV;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Influenza;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.JE;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Measles;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Meningococcal;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.MeningococcalB;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Mumps;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Orthopoxvirus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Pertussis;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Pneumococcal;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Polio;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Rabies;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Rotavirus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.RSV;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Rubella;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.TBE;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Tetanus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Typhoid;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Varicella;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.YF;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Zoster;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class DropAll
   {
      public static void Execute()
      {
         Vaccine_CholeraD.DeleteXmlDataInDatabase();
         Vaccine_COVID19D.DeleteXmlDataInDatabase();
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
      }
   }
}
