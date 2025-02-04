import logging
import sys
from logging_config import configure_logging

# Define the log file path
log_file_path = r'A:\New.New\VaxxVault\Dir\temp\error_log.txt'

# Configure logging
configure_logging(log_file_path)

def fetch_and_display_data(query, fetch_rows, display_table):
    try:
        rows, description = fetch_rows(query)
        logging.info(f"Fetched rows: {rows}")
        logging.info(f"Description: {description}")
        display_table(rows, ["ID", "SeriesName"])
        return rows, description
    except Exception as e:
        logging.error("Failed to fetch and display data: %s", e)
        print("An error occurred while fetching data. Please check the logs for more details.")
        sys.exit()
