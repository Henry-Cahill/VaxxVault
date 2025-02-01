import logging
import json
import os

def extract_and_store_data(rows, file_path):
    data_list = []
    for row in rows:
        logging.info(f"Row data: {row}")
        data = {
            "Immunity": row.Immunity,
            "Contraindications": row.Contraindications,
            "VaccineGroup": row.VaccineGroup,
            "Contraindication": row.Contraindication,
            "ObservationCode": row.ObservationCode,
            "ObservationTitle": row.ObservationTitle,
            "ContraindicationText": row.ContraindicationText,
            "ContraindicationGuidance": row.ContraindicationGuidance,
            "BeginAge": row.BeginAge,
            "EndAge": row.EndAge,
            "SeriesName": row.SeriesName,
            "TargetDisease": row.TargetDisease,
            "RequiredGender": row.RequiredGender,
            "DefaultSeries": row.DefaultSeries,
            "ProductPath": row.ProductPath,
            "SeriesGroupName": row.SeriesGroupName,
            "SeriesGroup": row.SeriesGroup,
            "SeriesPriority": row.SeriesPriority,
            "SeriesPreference": row.SeriesPreference,
            "MinAgeToStart": row.MinAgeToStart,
            "MaxAgeToStart": row.MaxAgeToStart,
            "ObservationCode_Indication": row.ObservationCode,
            "ObservationText_Indication": row.ObservationText,
            "Description": row.Description,
            "BeginAge_Indication": row.BeginAge,
            "EndAge_Indication": row.EndAge,
            "DoseNumber": row.DoseNumber,
            "AbsMinAge": row.AbsMinAge,
            "MinAge": row.MinAge,
            "EarliestRecAge": row.EarliestRecAge,
            "LatestRecAge": row.LatestRecAge,
            "MaxAge": row.MaxAge,
            "PreferableVaccineType": row.PreferableVaccineType,
            "PreferableVaccineCVX": row.PreferableVaccineCVX,
            "PreferableVaccineBeginAge": row.PreferableVaccineBeginAge,
            "PreferableVaccineEndAge": row.PreferableVaccineEndAge,
            "PreferableVaccineVolume": row.PreferableVaccineVolume,
            "PreferableVaccineForecastType": row.PreferableVaccineForecastType,
            "AllowableVaccineType": row.AllowableVaccineType,
            "AllowableVaccineCVX": row.AllowableVaccineCVX,
            "AllowableVaccineBeginAge": row.AllowableVaccineBeginAge,
            "AllowableVaccineEndAge": row.AllowableVaccineEndAge
        }
        data_list.append(data)
        logging.info(f"Fetched data for row ID: {row.ID}")

    try:
        with open(file_path, 'w') as file:
            json.dump(data_list, file, indent=4)
        logging.info("Data saved to %s", file_path)
    except Exception as e:
        logging.error("Error saving data to file: %s", e, exc_info=True)
        raise

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.