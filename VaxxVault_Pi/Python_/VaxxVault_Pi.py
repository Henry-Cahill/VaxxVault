import os
import sys
import logging
import subprocess
from typing import Dict

# Configure logging to write to both console and file
log_file_path = r'A:\New.New\VaxxVault\Dir\temp\error_log.txt'
logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s', handlers=[
    logging.FileHandler(log_file_path),
    logging.StreamHandler(sys.stdout)
])

# Define the file paths for the scripts
file_paths: Dict[str, str] = {
    '1': 'Python3_Vaccine_Select.py',
    '2': 'Python3_Vaccine_Definition.py',
    '3': 'Python3_DataFrame.py',
    '4': 'Python3_Validation.py'
}

def execute_script(script_file: str) -> None:
    # Construct the full path to the script
    script_path = os.path.join(os.path.dirname(__file__), script_file)
    
    # Check if the file exists
    if os.path.exists(script_path):
        logging.info(f"Executing script: {script_file}")
        try:
            # Execute the script using subprocess
            result = subprocess.run([sys.executable, script_path], check=True, capture_output=True, text=True)
            logging.info(f"Finished executing script: {script_file}")
            logging.info(f"Output: {result.stdout}")
            if result.stderr:
                logging.error(f"Error output: {result.stderr}")
        except subprocess.CalledProcessError as e:
            logging.error(f"An error occurred while executing the script: {e}")
            print(f"Error: An error occurred while executing the script: {e}")
    else:
        logging.error(f"File not found: {script_path}")
        print(f"Error: File not found: {script_path}")

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
        elif option in file_paths:
            execute_script(file_paths[option])
        else:
            logging.error("Invalid option selected.")
            print("Error: Invalid option selected.")

    # Pause to allow user to see the log output
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()