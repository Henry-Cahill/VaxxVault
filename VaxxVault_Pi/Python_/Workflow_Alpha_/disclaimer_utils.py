import sys
import logging
from logging_config import configure_logging

# Configure logging
log_file_path = r'A:\New.New\VaxxVault\Dir\temp\error_log.txt'
configure_logging(log_file_path)

def display_disclaimer():
    print("LEGAL DISCLAIMER:")
    print("By authorizing the execution of these commands, you acknowledge and agree that:")
    print("1. You have the necessary permissions and authority to execute these commands.")
    print("2. Executing these commands will modify the database, and you understand the consequences.")
    print("3. You accept full responsibility for any changes made to the database.")
    print("4. The authors of this software are not liable for any damages, data loss, or other issues arising from the execution of these commands.")
    print("5. You have reviewed and understand the commands that will be executed.")
    sys.stdout.flush()  # Ensure the disclaimer is printed before waiting for input

def get_user_authorization():
    authorization = input("Do you authorize the execution of these commands? (yes/no): ").strip().lower()
    if authorization != 'yes':
        logging.info("User did not authorize the execution of commands. Exiting.")
        print("Execution not authorized. Exiting.")
        logging.info("Exiting main function")
        sys.exit()
