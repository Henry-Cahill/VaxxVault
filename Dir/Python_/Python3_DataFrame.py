# File: Dir/Python_/Python3_DataFrame.py
import os
import json
import logging
import pandas as pd

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

# Create a DataFrame from the list of dictionaries
df = pd.DataFrame(data_list)

# Log the DataFrame
logging.info("DataFrame created with the following data:")
logging.info("\n%s", df)

# Save the DataFrame to a CSV file for further analysis
csv_file_path = os.path.join(os.path.dirname(__file__), 'vaccine_data.csv')
try:
    df.to_csv(csv_file_path, index=False)
    logging.info("DataFrame saved to %s", csv_file_path)
except IOError as e:
    logging.error("Error writing to file %s: %s", csv_file_path, e)
    sys.exit(1)

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.


