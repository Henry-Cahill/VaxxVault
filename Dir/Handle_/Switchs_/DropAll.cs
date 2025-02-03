using System;
using VaxxVault_V0002.Dir.Drop_;

namespace VaxxVault_V0002.Dir.Handle
{
   internal class DropAll
   {
      public static void Execute()
      {
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
      }
   }
}
