public static class VaccineSQLStore
{
   /// <summary>
   /// Executes QueryA to retrieve vaccine data.
   /// </summary>
   public static void QueryA()
   {
      string query = @"
   SELECT 
       XmlData.value('(/antigenSupportingData/immunity)[1]', 'VARCHAR(100)') AS Immunity,
       XmlData.value('(/antigenSupportingData/contraindications)[1]', 'VARCHAR(100)') AS Contraindications,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup)[1]','VARCHAR(100)') AS VaccineGroup,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication)[1]','VARCHAR(100)') AS Contraindication,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/observationCode)[1]','VARCHAR(100)') AS ObservationCode,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/observationTitle)[1]','VARCHAR(100)') AS ObservationTitle,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/contraindicationText)[1]','VARCHAR(100)') AS ContraindicationText,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/contraindicationGuidance)[1]','VARCHAR(100)') AS ContraindicationGuidance,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/beginAge)[1]','VARCHAR(100)') AS BeginAge,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/endAge)[1]','VARCHAR(100)') AS EndAge,
       XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName,
       XmlData.value('(/antigenSupportingData/series/targetDisease)[1]', 'VARCHAR(100)') AS TargetDisease,
       XmlData.value('(/antigenSupportingData/series/vaccineGroup)[1]', 'VARCHAR(100)') AS VaccineGroup,
       XmlData.value('(/antigenSupportingData/series/equivalentSeriesGroups)[1]', 'VARCHAR(100)') AS EquivalentSeriesGroups,
       XmlData.value('(/antigenSupportingData/series/requiredGender)[1]', 'VARCHAR(100)') AS RequiredGender,
       XmlData.value('(/antigenSupportingData/series/selectSeries/defaultSeries)[1]', 'VARCHAR(100)') AS DefaultSeries,
       XmlData.value('(/antigenSupportingData/series/selectSeries/productPath)[1]', 'VARCHAR(100)') AS ProductPath,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesGroupName)[1]', 'VARCHAR(100)') AS SeriesGroupName,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesGroup)[1]', 'VARCHAR(100)') AS SeriesGroup,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesPriority)[1]', 'VARCHAR(100)') AS SeriesPriority,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesPreference)[1]', 'VARCHAR(100)') AS SeriesPreference,
       XmlData.value('(/antigenSupportingData/series/selectSeries/minAgeToStart)[1]', 'VARCHAR(100)') AS MinAgeToStart,
       XmlData.value('(/antigenSupportingData/series/selectSeries/maxAgeToStart)[1]', 'VARCHAR(100)') AS MaxAgeToStart,
       XmlData.value('(/antigenSupportingData/series/indication/observationCode/code)[1]', 'VARCHAR(100)') AS ObservationCode,
       XmlData.value('(/antigenSupportingData/series/indication/observationCode/text)[1]', 'VARCHAR(100)') AS ObservationText,
       XmlData.value('(/antigenSupportingData/series/indication/description)[1]', 'VARCHAR(100)') AS Description,
       XmlData.value('(/antigenSupportingData/series/indication/beginAge)[1]', 'VARCHAR(100)') AS BeginAge,
       XmlData.value('(/antigenSupportingData/series/indication/endAge)[1]', 'VARCHAR(100)') AS EndAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/doseNumber)[1]', 'VARCHAR(100)') AS DoseNumber,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/absMinAge)[1]', 'VARCHAR(100)') AS AbsMinAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/minAge)[1]', 'VARCHAR(100)') AS MinAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/earliestRecAge)[1]', 'VARCHAR(100)') AS EarliestRecAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/latestRecAge)[1]', 'VARCHAR(100)') AS LatestRecAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/maxAge)[1]', 'VARCHAR(100)') AS MaxAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/vaccineType)[1]', 'VARCHAR(100)') AS PreferableVaccineType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/cvx)[1]', 'VARCHAR(100)') AS PreferableVaccineCVX,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/beginAge)[1]', 'VARCHAR(100)') AS PreferableVaccineBeginAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/endAge)[1]', 'VARCHAR(100)') AS PreferableVaccineEndAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/volume)[1]', 'VARCHAR(100)') AS PreferableVaccineVolume,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/forecastVaccineType)[1]', 'VARCHAR(100)') AS PreferableVaccineForecastType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/vaccineType)[1]', 'VARCHAR(100)') AS AllowableVaccineType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/cvx)[1]', 'VARCHAR(100)') AS AllowableVaccineCVX,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/beginAge)[1]', 'VARCHAR(100)') AS AllowableVaccineBeginAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/endAge)[1]', 'VARCHAR(100)') AS AllowableVaccineEndAge
   FROM VaccineData
   WHERE ID = ?;";
   }

   /// <summary>
   /// Executes QueryB to retrieve vaccine data.
   /// </summary>
   public static void QueryB()
   {
      string query = @"
   SELECT 
       XmlData.value('(/antigenSupportingData/immunity)[1]', 'VARCHAR(100)') AS Immunity,
       XmlData.value('(/antigenSupportingData/contraindications)[1]', 'VARCHAR(100)') AS Contraindications,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup)[1]','VARCHAR(100)') AS VaccineGroup,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication)[1]','VARCHAR(100)') AS Contraindication,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/observationCode)[1]','VARCHAR(100)') AS ObservationCode,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/observationTitle)[1]','VARCHAR(100)') AS ObservationTitle,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/contraindicationText)[1]','VARCHAR(100)') AS ContraindicationText,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/contraindicationGuidance)[1]','VARCHAR(100)') AS ContraindicationGuidance,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/beginAge)[1]','VARCHAR(100)') AS BeginAge,
       XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/endAge)[1]','VARCHAR(100)') AS EndAge,
       XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName,
       XmlData.value('(/antigenSupportingData/series/targetDisease)[1]', 'VARCHAR(100)') AS TargetDisease,
       XmlData.value('(/antigenSupportingData/series/vaccineGroup)[1]', 'VARCHAR(100)') AS VaccineGroup,
       XmlData.value('(/antigenSupportingData/series/equivalentSeriesGroups)[1]', 'VARCHAR(100)') AS EquivalentSeriesGroups,
       XmlData.value('(/antigenSupportingData/series/requiredGender)[1]', 'VARCHAR(100)') AS RequiredGender,
       XmlData.value('(/antigenSupportingData/series/selectSeries/defaultSeries)[1]', 'VARCHAR(100)') AS DefaultSeries,
       XmlData.value('(/antigenSupportingData/series/selectSeries/productPath)[1]', 'VARCHAR(100)') AS ProductPath,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesGroupName)[1]', 'VARCHAR(100)') AS SeriesGroupName,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesGroup)[1]', 'VARCHAR(100)') AS SeriesGroup,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesPriority)[1]', 'VARCHAR(100)') AS SeriesPriority,
       XmlData.value('(/antigenSupportingData/series/selectSeries/seriesPreference)[1]', 'VARCHAR(100)') AS SeriesPreference,
       XmlData.value('(/antigenSupportingData/series/selectSeries/minAgeToStart)[1]', 'VARCHAR(100)') AS MinAgeToStart,
       XmlData.value('(/antigenSupportingData/series/selectSeries/maxAgeToStart)[1]', 'VARCHAR(100)') AS MaxAgeToStart,
       XmlData.value('(/antigenSupportingData/series/indication/observationCode/code)[1]', 'VARCHAR(100)') AS ObservationCode,
       XmlData.value('(/antigenSupportingData/series/indication/observationCode/text)[1]', 'VARCHAR(100)') AS ObservationText,
       XmlData.value('(/antigenSupportingData/series/indication/description)[1]', 'VARCHAR(100)') AS Description,
       XmlData.value('(/antigenSupportingData/series/indication/beginAge)[1]', 'VARCHAR(100)') AS BeginAge,
       XmlData.value('(/antigenSupportingData/series/indication/endAge)[1]', 'VARCHAR(100)') AS EndAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/doseNumber)[1]', 'VARCHAR(100)') AS DoseNumber,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/absMinAge)[1]', 'VARCHAR(100)') AS AbsMinAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/minAge)[1]', 'VARCHAR(100)') AS MinAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/earliestRecAge)[1]', 'VARCHAR(100)') AS EarliestRecAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/latestRecAge)[1]', 'VARCHAR(100)') AS LatestRecAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/age/maxAge)[1]', 'VARCHAR(100)') AS MaxAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/vaccineType)[1]', 'VARCHAR(100)') AS PreferableVaccineType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/cvx)[1]', 'VARCHAR(100)') AS PreferableVaccineCVX,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/beginAge)[1]', 'VARCHAR(100)') AS PreferableVaccineBeginAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/endAge)[1]', 'VARCHAR(100)') AS PreferableVaccineEndAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/volume)[1]', 'VARCHAR(100)') AS PreferableVaccineVolume,
       XmlData.value('(/antigenSupportingData/series/seriesDose/preferableVaccine/forecastVaccineType)[1]', 'VARCHAR(100)') AS PreferableVaccineForecastType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/vaccineType)[1]', 'VARCHAR(100)') AS AllowableVaccineType,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/cvx)[1]', 'VARCHAR(100)') AS AllowableVaccineCVX,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/beginAge)[1]', 'VARCHAR(100)') AS AllowableVaccineBeginAge,
       XmlData.value('(/antigenSupportingData/series/seriesDose/allowableVaccine/endAge)[1]', 'VARCHAR(100)') AS AllowableVaccineEndAge
   FROM VaccineData;";
   }
}
