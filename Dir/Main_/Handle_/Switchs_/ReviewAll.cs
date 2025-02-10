using System;
using VaxxVault_V0002.Dir.Review_;
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
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Measles;
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.Meningococcal;
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
using VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Review_;

namespace VaxxVault_V0003.Dir.Main_.Handle_.Switchs_
{
   internal class ReviewAll
   {
      public static void Execute()
      {
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
      }
   }
}
