import logging
import pyodbc

# Database connection parameters
server = 'HLC-Laptop\\SQLEXPRESS'
database = 'CDSi_4.60'
connection_string = f'DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={server};DATABASE={database};Trusted_Connection=yes;'

def fetch_rows(query, params=None):
    logging.info("Entering fetch_rows function")
    conn = None
    try:
        conn = pyodbc.connect(connection_string)
        cursor = conn.cursor()
        logging.info("Executing query: %s", query)
        cursor.execute(query, params or ())
        rows = cursor.fetchall()
        columns = [column[0] for column in cursor.description]
        result = [dict(zip(columns, row)) for row in rows]
        logging.info("Query executed successfully. Number of rows fetched: %d", len(result))
        return result, cursor.description
    except pyodbc.Error as e:
        logging.error("Database error: %s", e)
        print("An error occurred while accessing the database.")
        raise
    finally:
        if conn:
            conn.close()
        logging.info("Exiting fetch_rows function")