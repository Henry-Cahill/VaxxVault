import os
import logging
import time
from typing import Dict
from logging_config import configure_logging
from script_executor import execute_script

# Configure logging
log_file_path = r'A:\New.New\VaxxVault\Dir\temp\error_log.txt'
configure_logging(log_file_path)

# Set environment variable to suppress GIL warning
os.environ['PYTHON_GIL'] = '0'

# Define the file paths for the scripts
file_paths: Dict[str, str] = {
    '1': 'Select_/Python3_Vaccine_Select.py',
    '2': 'Python3_Vaccine_Definition.py',
    '3': 'Python3_DataFrame.py',
    '4': 'Python3_Validation.py'
}

def main() -> None:
    while True:
        # Display options to the user
        print("Select the script to execute:")
        print("1. Vaccine Select")
        print("2. Vaccine Definition")
        print("3. DataFrame")
        print("4. Validation")
        print("5. Exit")
        print("6. Execute all scripts in order")
        option = input("Enter your choice (1/2/3/4/5/6): ").strip()

        if option == '5':
            logging.info("User selected to exit.")
            print("Exiting...")
            break
        elif option == '6':
            logging.info("User selected to execute all scripts in order.")
            for key in ['1', '2', '3', '4']:
                execute_script(file_paths[key])
                time.sleep(2)  # Add a 2-second delay after each script execution
        elif option in file_paths:
            execute_script(file_paths[option])
            time.sleep(2)  # Add a 2-second delay after script execution
        else:
            logging.error("Invalid option selected.")
            print("Error: Invalid option selected.")

    # Pause to allow user to see the log output
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()