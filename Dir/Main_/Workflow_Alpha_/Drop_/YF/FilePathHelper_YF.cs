namespace VaxxVault_V0003.Dir.Main_.Workflow_Alpha_.Drop_.YF
{
   internal static class FilePathHelper_YF
   {
      public static string GetFilePath(string version)
      {
         return version switch
         {
            "4.60" => @"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData- YF-508.xml",
            "4.59" => @"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData- YF-508.xml",
            "4.58" => @"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData- YF-508.xml",
            "4.57" => @"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData- YF-508.xml",
            _ => null
         };
      }
   }
}
