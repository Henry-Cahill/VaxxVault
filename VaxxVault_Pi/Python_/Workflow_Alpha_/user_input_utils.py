def handle_user_selection(fetch_rows, QueryA, QueryB, extract_and_store_data, display_table):
    print("\nOptions:")
    print("1. Select a specific row by ID")
    print("2. Select all rows")
    print("3. Select none (exit)")
    sys.stdout.flush()
    logging.info("Waiting for user input for option selection...")
    option = input("Enter your choice (1/2/3): ").strip()

    if option == '1':
        logging.info("User selected option 1. Waiting for user input for row ID...")
        selected_id = input("Enter the ID of the row you want to select: ").strip()
        if not selected_id.isdigit():
            logging.error("Invalid ID entered: %s", selected_id)
            print("Invalid ID entered. Exiting.")
            logging.info("Exiting main function")
            sys.exit()
        logging.info(f"User selected row ID: {selected_id}")
        try:
            rows, description = fetch_rows(QueryA, (selected_id,))
            if rows:
                data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
                logging.info("Extracting and storing data to: %s", data_file_path)
                extract_and_store_data(rows, data_file_path)
                display_table(rows, [desc[0] for desc in description])
            else:
                logging.error("No data returned for the selected ID.")
                print("No data returned for the selected ID.")
        except Exception as e:
            logging.error("Failed to fetch data for the selected ID: %s", e)
            print("An error occurred while fetching data. Please check the logs for more details.")
    elif option == '2':
        logging.info("User selected option 2. Fetching all rows...")
        try:
            rows, description = fetch_rows(QueryB)
            if rows:
                data_file_path = os.path.join(os.path.dirname(__file__), 'data.json')
                logging.info("Extracting and storing data to: %s", data_file_path)
                extract_and_store_data(rows, data_file_path)
                display_table(rows, [desc[0] for desc in description])
            else:
                logging.error("No data returned from the query.")
                print("No data returned from the query.")
        except Exception as e:
            logging.error("Failed to fetch all rows: %s", e)
            print("An error occurred while fetching data. Please check the logs for more details.")
    elif option == '3':
        logging.info("User selected option 3. Exiting.")
        logging.info("Exiting main function")
        sys.exit()
    else:
        logging.error("Invalid option selected. Exiting.")
        print("Invalid option selected. Exiting.")
        logging.info("Exiting main function")
        sys.exit()

