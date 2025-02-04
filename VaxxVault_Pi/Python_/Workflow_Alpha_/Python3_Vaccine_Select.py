import os
import sys
import logging
from logging_config import configure_logging

# Add the parent directory to the PYTHONPATH
sys.path.append(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from Python3_Vaccine_SQLStore import QueryA, QueryB  # type: ignore
from Python3_Vaccine_DataHandler import extract_and_store_data  # type: ignore
from database_utils import fetch_rows  # type: ignore
from display_utils import display_table  # type: ignore
from disclaimer_utils import display_disclaimer, get_user_authorization
from user_input_utils import handle_user_selection
from data_utils import fetch_and_display_data

print("PYTHONPATH:", os.environ.get('PYTHONPATH'))
print("Python executable:", sys.executable)

print("Python3_Vaccine_Select module executed.")

# Configure logging
log_file_path = 'A:\\New.New\\VaxxVault\\Dir\\temp\\error_log.txt'
configure_logging(log_file_path)
print("Logging configured")

def main():
    print("Entering main function")
    logging.info("Entering main function")

    display_disclaimer()
    get_user_authorization()

    list_query = "SELECT ID, XmlData.value('(/antigenSupportingData/series/seriesName)[1]', 'VARCHAR(100)') AS SeriesName FROM VaccineData"
    fetch_and_display_data(list_query, fetch_rows, display_table)

    handle_user_selection(fetch_rows, QueryA, QueryB, extract_and_store_data, display_table)

    logging.info("Exiting main function")

if __name__ == "__main__":
    main()



# Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.


