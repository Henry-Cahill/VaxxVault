import logging
from tabulate import tabulate

def display_table(rows, headers):
    logging.info("Entering display_table function")
    
    # Convert list of dictionaries to list of lists
    if rows and isinstance(rows[0], dict):
        table = [[row[header] for header in headers] for row in rows]
    else:
        table = rows
    
    print(tabulate(table, headers=headers, tablefmt="grid"))
    logging.info("Exiting display_table function")