using System;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Load_;

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
