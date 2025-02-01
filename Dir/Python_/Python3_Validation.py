# File: Dir/Python_/Python3_Validation.py
import os
import sys
import json
import logging
import pandas as pd
from lxml import etree

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
    with open(data_file_path, 'r') as file:
        data_list = json.load(file)
except json.JSONDecodeError as e:
    logging.error("Error decoding JSON from file %s: %s", data_file_path, e)
    sys.exit(1)

# Create XML data from the JSON data
root = etree.Element("antigenSupportingData")
for data in data_list:
    immunity = etree.SubElement(root, "immunity")
    immunity.text = data.get("Immunity", "")

    contraindications = etree.SubElement(root, "contraindications")
    vaccine_group = etree.SubElement(contraindications, "vaccineGroup")
    contraindication = etree.SubElement(vaccine_group, "contraindication")
    observation_code = etree.SubElement(contraindication, "observationCode")
    observation_code.text = data.get("ObservationCode", "")
    observation_title = etree.SubElement(contraindication, "observationTitle")
    observation_title.text = data.get("ObservationTitle", "")
    contraindication_text = etree.SubElement(contraindication, "contraindicationText")
    contraindication_text.text = data.get("ContraindicationText", "")
    contraindication_guidance = etree.SubElement(contraindication, "contraindicationGuidance")
    contraindication_guidance.text = data.get("ContraindicationGuidance", "")
    begin_age = etree.SubElement(contraindication, "beginAge")
    begin_age.text = data.get("BeginAge", "")
    end_age = etree.SubElement(contraindication, "endAge")
    end_age.text = data.get("EndAge", "")

    series = etree.SubElement(root, "series")
    series_name = etree.SubElement(series, "seriesName")
    series_name.text = data.get("SeriesName", "")
    target_disease = etree.SubElement(series, "targetDisease")
    target_disease.text = data.get("TargetDisease", "")
    vaccine_group = etree.SubElement(series, "vaccineGroup")
    vaccine_group.text = data.get("VaccineGroup", "")
    equivalent_series_groups = etree.SubElement(series, "equivalentSeriesGroups")
    equivalent_series_groups.text = data.get("EquivalentSeriesGroups", "")
    required_gender = etree.SubElement(series, "requiredGender")
    required_gender.text = data.get("RequiredGender", "")
    default_series = etree.SubElement(series, "defaultSeries")
    default_series.text = data.get("DefaultSeries", "")
    product_path = etree.SubElement(series, "productPath")
    product_path.text = data.get("ProductPath", "")
    series_group_name = etree.SubElement(series, "seriesGroupName")
    series_group_name.text = data.get("SeriesGroupName", "")
    series_group = etree.SubElement(series, "seriesGroup")
    series_group.text = data.get("SeriesGroup", "")
    series_priority = etree.SubElement(series, "seriesPriority")
    series_priority.text = data.get("SeriesPriority", "")
    series_preference = etree.SubElement(series, "seriesPreference")
    series_preference.text = data.get("SeriesPreference", "")
    min_age_to_start = etree.SubElement(series, "minAgeToStart")
    min_age_to_start.text = data.get("MinAgeToStart", "")
    max_age_to_start = etree.SubElement(series, "maxAgeToStart")
    max_age_to_start.text = data.get("MaxAgeToStart", "")

    indication = etree.SubElement(series, "indication")
    observation_code_indication = etree.SubElement(indication, "observationCode")
    code = etree.SubElement(observation_code_indication, "code")
    code.text = data.get("ObservationCode_Indication", "")
    text = etree.SubElement(observation_code_indication, "text")
    text.text = data.get("ObservationText_Indication", "")
    description = etree.SubElement(indication, "description")
    description.text = data.get("Description", "")
    begin_age_indication = etree.SubElement(indication, "beginAge")
    begin_age_indication.text = data.get("BeginAge_Indication", "")
    end_age_indication = etree.SubElement(indication, "endAge")
    end_age_indication.text = data.get("EndAge_Indication", "")

    series_dose = etree.SubElement(series, "seriesDose")
    dose_number = etree.SubElement(series_dose, "doseNumber")
    dose_number.text = data.get("DoseNumber", "")
    age = etree.SubElement(series_dose, "age")
    abs_min_age = etree.SubElement(age, "absMinAge")
    abs_min_age.text = data.get("AbsMinAge", "")
    min_age = etree.SubElement(age, "minAge")
    min_age.text = data.get("MinAge", "")
    earliest_rec_age = etree.SubElement(age, "earliestRecAge")
    earliest_rec_age.text = data.get("EarliestRecAge", "")
    latest_rec_age = etree.SubElement(age, "latestRecAge")
    latest_rec_age.text = data.get("LatestRecAge", "")
    max_age = etree.SubElement(age, "maxAge")
    max_age.text = data.get("MaxAge", "")

    preferable_vaccine = etree.SubElement(series_dose, "preferableVaccine")
    vaccine_type = etree.SubElement(preferable_vaccine, "vaccineType")
    vaccine_type.text = data.get("PreferableVaccineType", "")
    cvx = etree.SubElement(preferable_vaccine, "cvx")
    cvx.text = data.get("PreferableVaccineCVX", "")
    begin_age = etree.SubElement(preferable_vaccine, "beginAge")
    begin_age.text = data.get("PreferableVaccineBeginAge", "")
    end_age = etree.SubElement(preferable_vaccine, "endAge")
    end_age.text = data.get("PreferableVaccineEndAge", "")
    volume = etree.SubElement(preferable_vaccine, "volume")
    volume.text = data.get("PreferableVaccineVolume", "")
    forecast_vaccine_type = etree.SubElement(preferable_vaccine, "forecastVaccineType")
    forecast_vaccine_type.text = data.get("PreferableVaccineForecastType", "")

    allowable_vaccine = etree.SubElement(series_dose, "allowableVaccine")
    vaccine_type = etree.SubElement(allowable_vaccine, "vaccineType")
    vaccine_type.text = data.get("AllowableVaccineType", "")
    cvx = etree.SubElement(allowable_vaccine, "cvx")
    cvx.text = data.get("AllowableVaccineCVX", "")
    begin_age = etree.SubElement(allowable_vaccine, "beginAge")
    begin_age.text = data.get("AllowableVaccineBeginAge", "")
    end_age = etree.SubElement(allowable_vaccine, "endAge")
    end_age.text = data.get("AllowableVaccineEndAge", "")

# Convert the XML tree to a string
xml_data = etree.tostring(root, pretty_print=True, encoding='UTF-8').decode('UTF-8')

try:
    # Parse the XSD schema
    with open(xsd_path, 'rb') as xsd_file:
        xsd_doc = etree.parse(xsd_file)
        xsd = etree.XMLSchema(xsd_doc)

    # Parse the XSLT
    with open(xslt_path, 'rb') as xslt_file:
        xslt_doc = etree.parse(xslt_file)
        transform = etree.XSLT(xslt_doc)

    # Transform the XML data using the XSLT
    xml_doc = etree.fromstring(xml_data.encode('UTF-8'))
    transformed_xml = transform(xml_doc)

    # Validate the transformed XML against the XSD
    is_valid = xsd.validate(transformed_xml)
    print(f'XML is valid: {is_valid}')
    if not is_valid:
        for error in xsd.error_log:
            logging.error(error.message)
except FileNotFoundError as e:
    logging.error("File not found: %s", e)
    sys.exit(1)
except etree.XMLSyntaxError as e:
    logging.error("XML parsing error: %s", e)
    sys.exit(1)
except etree.XSLTParseError as e:
    logging.error("XSLT parsing error: %s", e)
    sys.exit(1)

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
