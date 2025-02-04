import subprocess
import os
import logging  # Import logging module here
import time
from typing import Dict
import sys
import argparse

# Add the Workflow_Alpha directory to the system path
sys.path.append(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', 'Workflow_Alpha_'))

# Add the directory containing logging_config to the system path
sys.path.append(os.path.join(os.path.dirname(os.path.abspath(__file__)), '..', r'A:\New.New\Python3.13.1\Lib\site-packages'))

try:
    from logging_config import configure_logging
except ImportError as e:
    logging.basicConfig(level=logging.ERROR)
    logging.error(f"Failed to import logging_config: {e}")
    sys.exit(1)

import Python3_Vaccine_Select  # type: ignore # Import the Python3_Vaccine_Select module

# Configure logging
log_file_path = r'A:\New.New\VaxxVault\Dir\temp\error_log.txt'
configure_logging(log_file_path)

# Define the file paths for the scripts relative to the current script's directory
base_dir = os.path.dirname(os.path.abspath(__file__))
file_paths: Dict[str, str] = {
    '1': os.path.join(base_dir, '..', 'Workflow_Alpha_', 'Python3_Vaccine_Select.py'),
    '2': os.path.join(base_dir, 'Python3_Vaccine_Definition.py'),
    '3': os.path.join(base_dir, 'Python3_DataFrame.py'),
    '4': os.path.join(base_dir, 'Python3_Validation.py')
}

def execute_script(script_path: str) -> None:
    try:
        logging.info(f"Starting execution of script: {script_path}")
        result = subprocess.run(
            ['python', script_path],
            capture_output=True,
            text=True,
            check=True
        )
        logging.info(f"Executed script: {script_path}")
        logging.info(f"Output: {result.stdout}")
        if result.stderr:
            logging.error(f"Error output: {result.stderr}")
    except subprocess.CalledProcessError as e:
        logging.error(f"Failed to execute script {script_path}: {e}")
        logging.error(f"Error output: {e.stderr}")
    except Exception as e:
        logging.error(f"An unexpected error occurred while executing script {script_path}: {e}")

def display_menu() -> None:
    logging.info("Displaying menu to the user.")
    print("Select the script to execute:")
    print("1. Vaccine Select")
    print("2. Vaccine Definition")
    print("3. DataFrame")
    print("4. Validation")
    print("5. Exit")
    print("6. Execute all modules in order")

def handle_option(option: str) -> None:
    logging.info(f"Handling user option: {option}")
    try:
        if option == '1':
            logging.info("User selected option 1. Executing Python3_Vaccine_Select.main()")
            Python3_Vaccine_Select.main()
        elif option == '5':
            logging.info("User selected to exit.")
            print("Exiting...")
            sys.exit(0)
        elif option == '6':
            logging.info("User selected to execute all modules in order.")
            for key in ['1', '2', '3', '4']:
                execute_script(file_paths[key])
                time.sleep(2)  # Add a 2-second delay after each script execution
                input("Press Enter to continue to the next script...")
        elif option in file_paths:
            execute_script(file_paths[option])
            time.sleep(2)  # Add a 2-second delay after script execution
            input("Press Enter to continue...")
        else:
            logging.error("Invalid option selected.")
            print("Error: Invalid option selected. Please enter a number between 1 and 6.")
    except Exception as e:
        logging.error(f"An error occurred while handling option {option}: {e}")

def main() -> None:
    logging.info("Starting main function.")
    parser = argparse.ArgumentParser(description="VaxxVault Script Executor")
    parser.add_argument('-o', '--option', type=str, help="Option to execute a specific script")
    args = parser.parse_args()

    if args.option:
        logging.info(f"Command-line option provided: {args.option}")
        handle_option(args.option)
    else:
        while True:
            display_menu()
            option = input("Enter your choice (1/2/3/4/5/6): ").strip()
            if option in ['1', '2', '3', '4', '5', '6']:
                logging.info(f"User input received: {option}")
                handle_option(option)
            else:
                logging.error("Invalid option selected.")
                print("Error: Invalid option selected. Please enter a number between 1 and 6.")

    # Pause to allow user to see the log output
    logging.info("Pausing to allow user to see the log output.")
    input("Press Enter to exit...")

if __name__ == "__main__":
    main()