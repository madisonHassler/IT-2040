## Project 2: Sales Data Analyzer

**Description:** This project is similar to the Analyze Music Playlist Challenge you completed in module 12. You should use the module 12 challenge for reference as you work through completing this project.

For this project you are to create a C#/.NET console application that analyzes sales data contained in a comma-delimited data file and generates a report that answers a set of provided questions that is saved in a text file. The path to the sales data file and the path to the report text file are provided to the program as command line arguments. If the user runs the program without supplying the arguments, they are to be provided with the syntax for running the program. All exceptions and errors are to be appropriately handled by giving the user feedback and exiting the program. Under no circumstances is the program to crash.

**Purpose:** This project evaluates your ability to create a C#/.NET console application that accepts command line arguments, reads and parses tab-delimited data, creates data structures, queries data using LINQ, writes a report to a text file, and handles exceptions/errors.

Project Name: SalesDataAnalyzer   
Target Platform: Console    
Development Platform: .NET Core   
Programming Language: C#

The program is to receive the path to a comma-delimited data file containing slaes information as a command line argument. If the comma-delimited data file is in the same directory as the program, then the user can just supply the name of the file as the path.

The records in the comma-delimited data file are to be read by the program and placed in a collection of structured data. Then, Language Integrated Query (LINQ) along with general C# code is to be used to determine the answers to a set of questions and a report is to be generated in a text file that is saved. The path of the report file is also to be supplied as a command line argument. If the path of the report file is just the name of the file, then it will be saved in the current directory.

When the application is being run, tested, and debugged in Visual Studio Code, place the salesData.csv file in the same directory as the SalesDataAnalyzer.csproj and Program.cs files. When the program runs from within Visual Studio Code from the Terminal, the project directory is the current directory and where salesData.csv is found, if the name of the file is supplied as the path.

### Sales Data Comma-Delimited Data File
Data source for the application: supermarket_sales.csv.zip Download supermarket_sales.csv.zip

The data in this file was collected from a supermarket in the year 2019.

The first line of the data file is comprised of the headers that identify the columns

```
Invoice ID,Branch,City,Customer type,Gender,Product line,Unit price,Quantity,Date,Payment,Rating
```

You can inspect the data file using a plain text editor. Use the headers to identify the meaning of the data. When your program reads the file, the first line needs to be skipped since it doesn’t contain data. When a line is read from the file, it can be split on the comma so that the pieces of data are put in an array. The order of the data elements in the array will be the same order as they are listed in a record in a line.

### Handle Errors
A well-written program should not crash regardless of the input or data provided to it. You are to handle all exceptions and error conditions that arise when the program is run. If an exception or error occurs, it is to be reported to the user and the program is to exit.

If the user runs the program without providing the two command line parameters, then the program is to display a message to the user indicating how the program is to be run.

```
SalesDataAnalyzer <sales_data_file_path> <report_file_path>
```

The following are some of the errors that could occur that need to be handled. Note, there is no implication that these are all the possible errors. They are being provided to give you a sense of error conditions that could arise that need to be handled.

- Sales data data file can’t be opened.
- Error occurs reading lines from sales data file.
- Record doesn’t contain the correct number of data elements.
- Record contains data that is not of the right type. Note: Some data elements are strings and some are integers.
- Report file can’t be opened or written to.
When you display an error message to the user, be as specific as possible about the problem and where it occurred. For example, if a record is malformed the line number of the record in the file should be included in the message to the user along with any other info that could be helpful in finding and correcting the problem.

The following is an example of an error message to the user when the wrong number of values is encountered in a record.

```
$"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}."
```

### Questions
1. Calculate the total sales in the data set.
2. Show the unique product lines in the data set.
3. Calculate the total sales for each product line. Sales total will be the sum of (Quantity * UnitPrice) for all products sold in the product line. List the product line and total sales.
4. Calculate the total Sales per city? List the city name and total sales.
5. Which product line(s) have the sale with the highest unit price? List the product line and the price.
6. Calculate the total sales per month in the data set. List the city month and total sales.
7. Calculate the total sales per payment type. List the payment type and total sales.
8. Calculate the number of sales transactions per member type. List the member type and number of transactions.
9. Calculate the average rating per product line. List the product line and the average rating.
10. Calculate the total number of transactions per payment type. List the payment type and number of transactions.
11. Calculate the total quantity of products sold per city. List the city and number of products sold.
12. Using a 5% sales tax, Calculate the tax for each sales transaction in each product line. List the invoice number, total sales for the transaction, and the tax amount for the transaction, ordered by the product line.

### Project output
The linked file below contains the output for this project. Your output should be consistent with it.

Report file: project2_report.txt Download project2_report.txt

