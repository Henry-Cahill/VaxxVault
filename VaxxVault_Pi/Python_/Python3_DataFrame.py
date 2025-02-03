# File: Dir/Python_/Python3_DataFrame.py
import os
import json
import logging
import clr
from System import Data
from System.IO import StreamWriter

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

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

# Create a DataTable from the list of dictionaries
data_table = Data.DataTable("VaccineData")
if data_list:
    # Add columns
    for key in data_list[0].keys():
        data_table.Columns.Add(key, Data.Type.GetType("System.String"))

    # Add rows
    for item in data_list:
        row = data_table.NewRow()
        for key, value in item.items():
            row[key] = value
        data_table.Rows.Add(row)

# Log the DataTable
logging.info("DataTable created with the following data:")
for row in data_table.Rows:
    logging.info(", ".join([str(row[col]) for col in data_table.Columns]))

# Save the DataTable to a CSV file for further analysis
csv_file_path = os.path.join(os.path.dirname(__file__), 'vaccine_data.csv')
try:
    with StreamWriter(csv_file_path) as file:
        # Write columns
        file.WriteLine(",".join([col.ColumnName for col in data_table.Columns]))
        # Write rows
        for row in data_table.Rows:
            file.WriteLine(",".join([str(row[col]) for col in data_table.Columns]))
    logging.info("DataTable saved to %s", csv_file_path)
except IOError as e:
    logging.error("Error writing to file %s: %s", csv_file_path, e)
    sys.exit(1)

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.


