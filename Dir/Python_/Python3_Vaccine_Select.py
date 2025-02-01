import os
import sys
import pyodbc
import logging
import json
import tempfile

# Import the SQL queries from Python3_Vaccine_SQLStore and from Python3_Vaccine_DataHandler
from Python3_Vaccine_SQLStore import QueryA, QueryB
from Python3_Vaccine_DataHandler import extract_and_store_data

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')

# Create a temporary log file for errors
temp_log_file = os.path.join(tempfile.gettempdir(), 'vaccine_select_errors.log')
file_handler = logging.FileHandler(temp_log_file)
file_handler.setLevel(logging.ERROR)
file_handler.setFormatter(logging.Formatter('%(asctime)s - %(levelname)s - %(message)s'))
logging.getLogger().addHandler(file_handler)

# Add the directory containing Python3_Credentials.py to sys.path
secure_dir = os.path.abspath(os.path.join(os.path.dirname(__file__), '..', 'Secure_'))
sys.path.append(secure_dir)

# Log sys.path to verify the directory is added
logging.info("sys.path: %s", sys.path)

# List files in the Secure_ directory to verify Python3_Credentials.py is present
try:
    secure_files = os.listdir(secure_dir)
    logging.info("Files in Secure_ directory: %s", secure_files)
except Exception as e:
    logging.error("Error listing files in Secure_ directory: %s", e, exc_info=True)
    raise

# Import the MyClass from Python3_Credentials
try:
    from Python3_Credentials import MyClass
except ImportError as e:
    logging.error("Error importing MyClass from Python3_Credentials: %s", e, exc_info=True)
    raise

# Instantiate the class to set environment variables
try:
    credentials = MyClass()
except Exception as e:
    logging.error("Error instantiating MyClass: %s", e, exc_info=True)
    raise

# Database connection parameters
server = 'HLC-Laptop\\SQLEXPRESS'
database = 'CDSi_4.60'

# Use integrated security for the connection string
connection_string = f'DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes;'

try:
    # Connect to the database
    with pyodbc.connect(connection_string) as conn:
        logging.info("Database connection established.")
        with conn.cursor() as cursor:
            # Query to list available rows
            list_query = "SELECT ID, XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName FROM VaccineData"
            logging.info("Executing query: %s", list_query)  # Log the SELECT statement execution
            cursor.execute(list_query)
            rows = cursor.fetchall()

            # Display available rows to the user
            print("Available Vaccine Data Rows:")
            for row in rows:
                logging.info(f"Row data: {row}")
                print(f"ID: {row[0]}, SeriesName: {row[1]}")

            # Prompt the user to select a row
            print("\nOptions:")
            print("1. Select a specific row by ID")
            print("2. Select all rows")
            print("3. Select none (exit)")
            logging.info("Waiting for user input for option selection...")
            option = input("Enter your choice (1/2/3): ")

            if option == '1':
                logging.info("User selected option 1. Waiting for user input for row ID...")
                selected_id = input("Enter the ID of the row you want to select: ")
                logging.info(f"User selected row ID: {selected_id}")
                logging.info("Executing query: %s", QueryA)  # Log the SELECT statement execution
                cursor.execute(QueryA, selected_id)
                rows = cursor.fetchall()
                if rows:
                    data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
                    extract_and_store_data(rows, data_file_path)
                else:
                    logging.error("No data returned for the selected ID.")
                    print("No data returned for the selected ID.")

            elif option == '2':
                logging.info("User selected option 2. Fetching all rows...")
                logging.info("Executing query: %s", QueryB)  # Log the SELECT statement execution
                cursor.execute(QueryB)
                rows = cursor.fetchall()
                if rows:
                    data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
                    extract_and_store_data(rows, data_file_path)
                else:
                    logging.error("No data returned from the query.")
                    print("No data returned from the query.")

            elif option == '3':
                logging.info("User selected option 3. Exiting.")
                sys.exit(0)
            else:
                logging.error("Invalid option selected. Exiting.")
                sys.exit(1)

except pyodbc.Error as e:
    logging.error("Database error occurred: %s", e, exc_info=True)  # Log the error with traceback
    raise RuntimeError("A database error occurred. Please check the logs for more details.") from e
except Exception as e:  # Catch any other exceptions
    logging.error("An unexpected error occurred: %s", e, exc_info=True)  # Log the error with traceback
    raise RuntimeError("An unexpected error occurred. Please check the logs for more details.") from e
    sys.exit(1)
# End of Python3_Vaccine_Select.py

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.
