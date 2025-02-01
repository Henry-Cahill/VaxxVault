# File: Dir/Python_/Python3_Vaccine_Definition.py
import os
import json
import logging

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Load the data from the previous script
data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
if not os.path.exists(data_file_path):
    logging.error("Data file not found: %s", data_file_path)
    sys.exit(1)

try:
    with open(data_file_path, 'r') as file:
        data = json.load(file)
except json.JSONDecodeError as e:
    logging.error("Error decoding JSON from file %s: %s", data_file_path, e)
    sys.exit(1)

# Validate the data
required_keys = [
    "Immunity", "Contraindications", "VaccineGroup", "Contraindication", "ObservationCode",
    "ObservationTitle", "ContraindicationText", "ContraindicationGuidance", "BeginAge", "EndAge",
    "SeriesName", "TargetDisease", "RequiredGender", "DefaultSeries", "ProductPath",
    "SeriesGroupName", "SeriesGroup", "SeriesPriority", "SeriesPreference", "MinAgeToStart",
    "MaxAgeToStart", "ObservationCode_Indication", "ObservationText_Indication", "Description",
    "BeginAge_Indication", "EndAge_Indication", "DoseNumber", "AbsMinAge", "MinAge",
    "EarliestRecAge", "LatestRecAge", "MaxAge", "PreferableVaccineType", "PreferableVaccineCVX",
    "PreferableVaccineBeginAge", "PreferableVaccineEndAge", "PreferableVaccineVolume",
    "PreferableVaccineForecastType", "AllowableVaccineType", "AllowableVaccineCVX",
    "AllowableVaccineBeginAge", "AllowableVaccineEndAge"
]

for key in required_keys:
    if key not in data:
        logging.error("Missing required key in data: %s", key)
        sys.exit(1)

# Create a dictionary to hold the data
data_dict = {key: data[key] for key in required_keys}

# Save the dictionary to a file for the next script to use
definition_file_path = os.path.join(os.path.dirname(__file__), 'definition.json')
try:
    with open(definition_file_path, 'w') as file:
        json.dump(data_dict, file, indent=4)
    logging.info("Data dictionary created and saved to %s", definition_file_path)
except IOError as e:
    logging.error("Error writing to file %s: %s", definition_file_path, e)
    sys.exit(1)

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.