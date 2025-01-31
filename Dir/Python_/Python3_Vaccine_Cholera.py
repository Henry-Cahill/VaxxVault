# File: Dir/Python_/Python3_Vaccine_Cholera.py
import os
import sys
import pyodbc
import logging
from lxml import etree

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Add the directory containing Python3_Credentials.py to sys.path
secure_dir = os.path.abspath(os.path.join(os.path.dirname(__file__), '..', 'Secure_'))
sys.path.append(secure_dir)

# Log sys.path to verify the directory is added
logging.info("sys.path: %s", sys.path)

# List files in the Secure_ directory to verify Python3_Credentials.py is present
logging.info("Files in Secure_ directory: %s", os.listdir(secure_dir))

# Import the MyClass from Python3_Credentials
from Python3_Credentials import MyClass

# Instantiate the class to set environment variables
credentials = MyClass()

# Database connection parameters
server = 'HLC-Laptop\\SQLEXPRESS'
database = 'CDSi_4.60'

# Use integrated security for the connection string
connection_string = f'DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes;'

try:
    # Connect to the database
    with pyodbc.connect(connection_string) as conn:
        with conn.cursor() as cursor:
            # Execute the query to retrieve XML data
            query = """
            SELECT 
                XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName, 
                XmlData.value('(/antigenSupportingData/contraindications/vaccineGroup/contraindication/observationTitle)[1]', 'VARCHAR(100)') AS FirstObservationTitle 
            FROM VaccineData;
            """
            cursor.execute(query)

            # Fetch the XML data
            row = cursor.fetchone()
            if row:
                series_name = row[0]
                observation_title = row[1]
                # Log the fetched data
                logging.info("Series Name: %s", series_name)
                logging.info("First Observation Title: %s", observation_title)
            else:
                logging.error("No data returned from the query.")
                sys.exit(1)

except pyodbc.Error as e:
    logging.error("Database error: %s", e)
    sys.exit(1)

# Check if series_name or observation_title is None or empty
if not series_name or not observation_title:
    logging.error("No valid data retrieved from the database.")
    sys.exit(1)

# Construct XML data from the fetched values
xml_data = f"""
<antigenSupportingData>
    <series>
        <seriesName>{series_name}</seriesName>
    </series>
    <contraindications>
        <vaccineGroup>
            <contraindication>
                <observationTitle>{observation_title}</observationTitle>
            </contraindication>
        </vaccineGroup>
    </contraindications>
</antigenSupportingData>
"""

# Parse the XML data
try:
    root = etree.fromstring(xml_data)
except etree.XMLSyntaxError as e:
    logging.error("XML parsing error: %s", e)
    sys.exit(1)

# Log the entire XML structure
logging.info("XML Data: %s", etree.tostring(root, pretty_print=True, encoding='unicode'))

# Extract desired data (example for a particular tag)
for elem in root.findall('.//antigenSupportingData'):
    logging.info("Antigen Supporting Data: %s", etree.tostring(elem, encoding='unicode'))

#Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
