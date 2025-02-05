using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Cholera;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.COVID19;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Dengue;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Diphtheria;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Ebola;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.HepA;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.HepB;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Hib;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.HPV;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Influenza;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.JE;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Measles;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Meningococcal;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.MeningococcalB;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Mumps;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Orthopoxvirus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Pertussis;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Pneumococcal;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Polio;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rabies;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rotavirus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.RSV;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Rubella;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.TBE;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Tetanus;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Typhoid;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Varicella;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.YF;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_.Zoster;

namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Handle_.Switchs_
{
   internal class LoadAll
   {
      public static void Execute()
      {
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
      }
   }
}
