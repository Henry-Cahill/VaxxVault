# File: Dir/Python_/Python3_Validation.py
import os
import sys
import logging
import clr
from System import IO, Text
from System.Xml import XmlDocument, XmlReader, XmlWriterSettings
from System.Xml.Schema import XmlSchemaSet, XmlSchemaValidationFlags, ValidationEventHandler
from System.Xml.Xsl import XslCompiledTransform

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Prompt the user to select the CDSi version
print("Select the CDSi version for validation:")
print("1. Version 4.57")
print("2. Version 4.58")
print("3. Version 4.59")
print("4. Version 4.60 (default)")
version_option = input("Enter your choice (1/2/3/4): ")

# Map the user's choice to the corresponding XSD file path
xsd_paths = {
    '1': r"A:\New.New\VaxxVault\Import\Version 4.57 - 508\XML\AntigenSupportingData.xsd",
    '2': r"A:\New.New\VaxxVault\Import\Version 4.58 - 508\XML\AntigenSupportingData.xsd",
    '3': r"A:\New.New\VaxxVault\Import\Version 4.59 - 508\XML\AntigenSupportingData.xsd",
    '4': r"A:\New.New\VaxxVault\Import\Version 4.60 - 508\XML\AntigenSupportingData.xsd"
}

# Default to version 4.60 if the user input is invalid
xsd_path = xsd_paths.get(version_option, xsd_paths['4'])

# Path to the XSLT file
xslt_path = r"A:\New.New\VaxxVault\Import\CDSi\antigensupportingdata.xslt"

# Load the data from the previous script
data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
if not os.path.exists(data_file_path):
    logging.error("Data file not found: %s", data_file_path)
    sys.exit(1)

try:
    with IO.StreamReader(data_file_path, Text.Encoding.UTF8) as file:
        json_data = file.ReadToEnd()
        serializer = clr.AddReference("System.Web.Extensions")
        from System.Web.Script.Serialization import JavaScriptSerializer
        serializer = JavaScriptSerializer()
        data_list = serializer.DeserializeObject(json_data)
except Exception as e:
    logging.error("Error decoding JSON from file %s: %s", data_file_path, e)
    sys.exit(1)

# Create XML data from the JSON data
root = XmlDocument()
root.LoadXml("<antigenSupportingData></antigenSupportingData>")
for data in data_list:
    immunity = root.CreateElement("immunity")
    immunity.InnerText = data.get("Immunity", "")
    root.DocumentElement.AppendChild(immunity)

    contraindications = root.CreateElement("contraindications")
    vaccine_group = root.CreateElement("vaccineGroup")
    contraindication = root.CreateElement("contraindication")
    observation_code = root.CreateElement("observationCode")
    observation_code.InnerText = data.get("ObservationCode", "")
    contraindication.AppendChild(observation_code)
    observation_title = root.CreateElement("observationTitle")
    observation_title.InnerText = data.get("ObservationTitle", "")
    contraindication.AppendChild(observation_title)
    contraindication_text = root.CreateElement("contraindicationText")
    contraindication_text.InnerText = data.get("ContraindicationText", "")
    contraindication.AppendChild(contraindication_text)
    contraindication_guidance = root.CreateElement("contraindicationGuidance")
    contraindication_guidance.InnerText = data.get("ContraindicationGuidance", "")
    contraindication.AppendChild(contraindication_guidance)
    begin_age = root.CreateElement("beginAge")
    begin_age.InnerText = data.get("BeginAge", "")
    contraindication.AppendChild(begin_age)
    end_age = root.CreateElement("endAge")
    end_age.InnerText = data.get("EndAge", "")
    contraindication.AppendChild(end_age)
    vaccine_group.AppendChild(contraindication)
    contraindications.AppendChild(vaccine_group)
    root.DocumentElement.AppendChild(contraindications)

    series = root.CreateElement("series")
    series_name = root.CreateElement("seriesName")
    series_name.InnerText = data.get("SeriesName", "")
    series.AppendChild(series_name)
    target_disease = root.CreateElement("targetDisease")
    target_disease.InnerText = data.get("TargetDisease", "")
    series.AppendChild(target_disease)
    vaccine_group = root.CreateElement("vaccineGroup")
    vaccine_group.InnerText = data.get("VaccineGroup", "")
    series.AppendChild(vaccine_group)
    equivalent_series_groups = root.CreateElement("equivalentSeriesGroups")
    equivalent_series_groups.InnerText = data.get("EquivalentSeriesGroups", "")
    series.AppendChild(equivalent_series_groups)
    required_gender = root.CreateElement("requiredGender")
    required_gender.InnerText = data.get("RequiredGender", "")
    series.AppendChild(required_gender)
    default_series = root.CreateElement("defaultSeries")
    default_series.InnerText = data.get("DefaultSeries", "")
    series.AppendChild(default_series)
    product_path = root.CreateElement("productPath")
    product_path.InnerText = data.get("ProductPath", "")
    series.AppendChild(product_path)
    series_group_name = root.CreateElement("seriesGroupName")
    series_group_name.InnerText = data.get("SeriesGroupName", "")
    series.AppendChild(series_group_name)
    series_group = root.CreateElement("seriesGroup")
    series_group.InnerText = data.get("SeriesGroup", "")
    series.AppendChild(series_group)
    series_priority = root.CreateElement("seriesPriority")
    series_priority.InnerText = data.get("SeriesPriority", "")
    series.AppendChild(series_priority)
    series_preference = root.CreateElement("seriesPreference")
    series_preference.InnerText = data.get("SeriesPreference", "")
    series.AppendChild(series_preference)
    min_age_to_start = root.CreateElement("minAgeToStart")
    min_age_to_start.InnerText = data.get("MinAgeToStart", "")
    series.AppendChild(min_age_to_start)
    max_age_to_start = root.CreateElement("maxAgeToStart")
    max_age_to_start.InnerText = data.get("MaxAgeToStart", "")
    series.AppendChild(max_age_to_start)

    indication = root.CreateElement("indication")
    observation_code_indication = root.CreateElement("observationCode")
    code = root.CreateElement("code")
    code.InnerText = data.get("ObservationCode_Indication", "")
    observation_code_indication.AppendChild(code)
    text = root.CreateElement("text")
    text.InnerText = data.get("ObservationText_Indication", "")
    observation_code_indication.AppendChild(text)
    indication.AppendChild(observation_code_indication)
    description = root.CreateElement("description")
    description.InnerText = data.get("Description", "")
    indication.AppendChild(description)
    begin_age_indication = root.CreateElement("beginAge")
    begin_age_indication.InnerText = data.get("BeginAge_Indication", "")
    indication.AppendChild(begin_age_indication)
    end_age_indication = root.CreateElement("endAge")
    end_age_indication.InnerText = data.get("EndAge_Indication", "")
    indication.AppendChild(end_age_indication)
    series.AppendChild(indication)

    series_dose = root.CreateElement("seriesDose")
    dose_number = root.CreateElement("doseNumber")
    dose_number.InnerText = data.get("DoseNumber", "")
    series_dose.AppendChild(dose_number)
    age = root.CreateElement("age")
    abs_min_age = root.CreateElement("absMinAge")
    abs_min_age.InnerText = data.get("AbsMinAge", "")
    age.AppendChild(abs_min_age)
    min_age = root.CreateElement("minAge")
    min_age.InnerText = data.get("MinAge", "")
    age.AppendChild(min_age)
    earliest_rec_age = root.CreateElement("earliestRecAge")
    earliest_rec_age.InnerText = data.get("EarliestRecAge", "")
    age.AppendChild(earliest_rec_age)
    latest_rec_age = root.CreateElement("latestRecAge")
    latest_rec_age.InnerText = data.get("LatestRecAge", "")
    age.AppendChild(latest_rec_age)
    max_age = root.CreateElement("maxAge")
    max_age.InnerText = data.get("MaxAge", "")
    age.AppendChild(max_age)
    series_dose.AppendChild(age)

    preferable_vaccine = root.CreateElement("preferableVaccine")
    vaccine_type = root.CreateElement("vaccineType")
    vaccine_type.InnerText = data.get("PreferableVaccineType", "")
    preferable_vaccine.AppendChild(vaccine_type)
    cvx = root.CreateElement("cvx")
    cvx.InnerText = data.get("PreferableVaccineCVX", "")
    preferable_vaccine.AppendChild(cvx)
    begin_age = root.CreateElement("beginAge")
    begin_age.InnerText = data.get("PreferableVaccineBeginAge", "")
    preferable_vaccine.AppendChild(begin_age)
    end_age = root.CreateElement("endAge")
    end_age.InnerText = data.get("PreferableVaccineEndAge", "")
    preferable_vaccine.AppendChild(end_age)
    volume = root.CreateElement("volume")
    volume.InnerText = data.get("PreferableVaccineVolume", "")
    preferable_vaccine.AppendChild(volume)
    forecast_vaccine_type = root.CreateElement("forecastVaccineType")
    forecast_vaccine_type.InnerText = data.get("PreferableVaccineForecastType", "")
    preferable_vaccine.AppendChild(forecast_vaccine_type)
    series_dose.AppendChild(preferable_vaccine)

    allowable_vaccine = root.CreateElement("allowableVaccine")
    vaccine_type = root.CreateElement("vaccineType")
    vaccine_type.InnerText = data.get("AllowableVaccineType", "")
    allowable_vaccine.AppendChild(vaccine_type)
    cvx = root.CreateElement("cvx")
    cvx.InnerText = data.get("AllowableVaccineCVX", "")
    allowable_vaccine.AppendChild(cvx)
    begin_age = root.CreateElement("beginAge")
    begin_age.InnerText = data.get("AllowableVaccineBeginAge", "")
    allowable_vaccine.AppendChild(begin_age)
    end_age = root.CreateElement("endAge")
    end_age.InnerText = data.get("AllowableVaccineEndAge", "")
    allowable_vaccine.AppendChild(end_age)
    series_dose.AppendChild(allowable_vaccine)

    series.AppendChild(series_dose)
    root.DocumentElement.AppendChild(series)

# Convert the XML tree to a string
xml_data = root.OuterXml

try:
    # Parse the XSD schema
    xsd = XmlSchemaSet()
    xsd.Add(None, xsd_path)

    # Parse the XSLT
    transform = XslCompiledTransform()
    transform.Load(xslt_path)

    # Transform the XML data using the XSLT
    xml_doc = XmlDocument()
    xml_doc.LoadXml(xml_data)
    transformed_xml = IO.StringWriter()
    settings = XmlWriterSettings()
    settings.Indent = True
    with XmlWriter.Create(transformed_xml, settings) as writer:
        transform.Transform(xml_doc, writer)

    # Validate the transformed XML against the XSD
    def validation_event_handler(sender, args):
        if args.Severity == XmlSeverityType.Error:
            logging.error(args.Message)
        elif args.Severity == XmlSeverityType.Warning:
            logging.warning(args.Message)

    xsd.ValidationEventHandler += ValidationEventHandler(validation_event_handler)
    xml_reader = XmlReader.Create(IO.StringReader(transformed_xml.ToString()), XmlReaderSettings())
    xsd.Validate(xml_reader)
    print('XML is valid')
except FileNotFoundError as e:
    logging.error("File not found: %s", e)
    sys.exit(1)
except Exception as e:
    logging.error("An error occurred: %s", e)
    sys.exit(1)

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
