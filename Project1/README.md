# **Project 1**
**Description:** Create a C# console application to process a payroll file and write a summary report.

**Purpose:** The purpose of this challenge is to test your knowledge with basic programming structures such as lists and list methods, functions, loops, and program design

**Requirements:**

- Project Name: Project1
- Target Platform: .NET Core Console Application
- Programming Language: C#

Create a program in C# called Project1 that process a payroll file.

**Data File**
Download the payroll.csv  Download payroll.csv file and place it in your C# program. The structure of the data in the file is as follows:
[payroll.csv](https://github.com/mehfmd/IT-2040/files/8187254/payroll.csv)

first_name,last_name,hours_worked,pay_rate

**Program Flow**
You program should do the following:

- Ask the user for their name
- Ask the user for the file to be read
- If the user file name provided does not end in ".csv" then your code should add ".csv" to the file name
- Read the data file line by line to get the individual pieces of data
- Calculate the pay for each worker
- Print each employees pay to the console
- Create a summary report named salarySummary.txt contains
    - Number of Employees
    - Total Payroll
    - Average Pay
    - Maximum Pay
    - Minimum Pay
- Output a message letting the user know the report was successfully written
- End the program

You must write a minimum of five (5) user defined functions. Writing a function to get the user name, or print the success message when the file is written, and the like will not count.
