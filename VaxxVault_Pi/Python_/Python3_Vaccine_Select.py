import os
import sys
import logging
import pyodbc
from tabulate import tabulate
from Python3_Vaccine_SQLStore import QueryA, QueryB
from Python3_Vaccine_DataHandler import extract_and_store_data

# Configure logging
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')
log_file_path = 'A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt'
file_handler = logging.FileHandler(log_file_path)
file_handler.setLevel(logging.ERROR)
file_handler.setFormatter(logging.Formatter('%(asctime)s - %(levelname)s - %(message)s'))
logging.getLogger().addHandler(file_handler)
logging.info("Logging setup complete. Log file: %s", log_file_path)

# Database connection parameters
server = 'HLC-Laptop\\SQLEXPRESS'
database = 'CDSi_4.60'
connection_string = f'DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes;'

def fetch_rows(query, params=None):
    try:
        with pyodbc.connect(connection_string) as conn:
            cursor = conn.cursor()
            logging.info("Executing query: %s", query)
            cursor.execute(query, params or ())
            rows = cursor.fetchall()
            logging.info("Query executed successfully. Number of rows fetched: %d", len(rows))
            return rows, cursor.description
    except pyodbc.Error as e:
        logging.error("Database error: %s", e)
        print("An error occurred while accessing the database.")
        sys.exit(1)

def display_table(rows, headers):
    table = [[row[i] for i in range(len(row))] for row in rows]
    print(tabulate(table, headers=headers, tablefmt="grid"))

def main():
    print("LEGAL DISCLAIMER:")
    print("By authorizing the execution of these commands, you acknowledge and agree that:")
    print("1. You have the necessary permissions and authority to execute these commands.")
    print("2. Executing these commands will modify the database, and you understand the consequences.")
    print("3. You accept full responsibility for any changes made to the database.")
    print("4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.")
    print("5. You have reviewed and understand the commands that will be executed.")
    authorization = input("Do you authorize the execution of these commands? (yes/no): ").strip().lower()

    if authorization != 'yes':
        logging.info("User did not authorize the execution of commands. Exiting.")
        print("Execution not authorized. Exiting.")
        sys.exit(0)

    list_query = "SELECT ID, XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName FROM VaccineData"
    rows, description = fetch_rows(list_query)
    display_table(rows, ["ID", "SeriesName"])

    print("\nOptions:")
    print("1. Select a specific row by ID")
    print("2. Select all rows")
    print("3. Select none (exit)")
    sys.stdout.flush()
    logging.info("Waiting for user input for option selection...")
    option = input("Enter your choice (1/2/3): ")

    if option == '1':
        logging.info("User selected option 1. Waiting for user input for row ID...")
        selected_id = input("Enter the ID of the row you want to select: ")
        if not selected_id.isdigit():
            logging.error("Invalid ID entered: %s", selected_id)
            print("Invalid ID entered. Exiting.")
            sys.exit(1)
        logging.info(f"User selected row ID: {selected_id}")
        rows, description = fetch_rows(QueryA, selected_id)
        if rows:
            data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
            logging.info("Extracting and storing data to: %s", data_file_path)
            extract_and_store_data(rows, data_file_path)
            display_table(rows, [desc[0] for desc in description])
        else:
            logging.error("No data returned for the selected ID.")
            print("No data returned for the selected ID.")
    elif option == '2':
        logging.info("User selected option 2. Fetching all rows...")
        rows, description = fetch_rows(QueryB)
        if rows:
            data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
            logging.info("Extracting and storing data to: %s", data_file_path)
            extract_and_store_data(rows, data_file_path)
            display_table(rows, [desc[0] for desc in description])
        else:
            logging.error("No data returned from the query.")
            print("No data returned from the query.")
    elif option == '3':
        logging.info("User selected option 3. Exiting.")
        sys.exit(0)
    else:
        logging.error("Invalid option selected. Exiting.")
        print("Invalid option selected. Exiting.")
        sys.exit(1)

if __name__ == "__main__":
    main()

# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.

