## Challenge: Crime Analyzer
**Description:** Create a C#/.NET console application that analyzes crime data based on a comma-separated-value (CSV) file and generates a report that answers a set of provided questions that is saved in a text file. The path to the CSV file and the path to the report text file are provided to the program as command line arguments. If the user runs the program without supplying the arguments, they should be provided with the syntax for running the program. All exceptions and errors are to be appropriately handled by giving the user feedback and exiting the program. Under no circumstances should the program crash.

**Purpose:** This application provides experience creating a C#/.NET console application, accepting command line arguments, reading and parsing CSV data, creating data structures, querying data using LINQ, writing a report to a text file, and handling exceptions/errors.

Project Name: CrimeAnalyzer   
Target Platform: Console/.NET   
Programming Language: C#

The program is to receive the path to the comma-separated-value (CSV) file as a command line argument. If the CSV file is in the same directory as the program, then the user can just supply the name of the file as the path.

The records in the CSV file are to be read by the program and placed in a collection of structured data. Then, Language INtegrated Query (LINQ) along with general C# code is to be used to determine the answers to a set of questions and a report is to be generated in a text file that is saved. The path of the report file is also to be supplied as a command line argument. If the path of the report file is just the name of the file, then it will be saved in the current directory.

To run a program in Visual Studio Code, in the Terminal enter dotnet run. To supply command line arguments put them after dotnet run as shown below and in the Command Line Arguments for C# Console App page.


When the program is run in the TERMINAL in Visual Studio Code the command line arguments are provided after dotnet run. In the above example the program was run with no command line arguments and it displayed Number of arguments: 0.  Then, the program was run with three command line arguments: first second third by using dotnet run first second third.  The first, second, and third are provided to the program in the string array args. When the three arguments are provided the program displays Number of arguments: 0 and then displays the three arguments: arg = first, arg = second, and arg = third.

When the application is being run, tested, and debugged in Visual Studio, place the CrimeData.csv file in the same directory as the CrimeAnalyzer.csproj, Program.cs, and your other code files. When the program runs from within Visual Studio Code Terminal using dotnet run, the project directory is the current directory and where CrimeData.csv will be found, if the name of the file is supplied as the path.

### Crime Data CSV File
The data source for the application is CrimeData.csv  Download CrimeData.csv  

The first line of the CSV file is comprised of the headers that identify the columns.

```
Year,Population,Violent Crime,Murder,Rape,Robbery,Aggravated Assault,Property Crime,Burglary,Theft,Motor Vehicle Theft
```

You can inspect the CSV file using a plain text editor. Use the headers to identify the meaning of the data. When your program reads the file, the first line needs to be skipped since it doesn’t contain data. Do not delete the first line of the CSV file. Other CSV files provided in the future will have the header, so you need to accept that it is present and handle it.

When a line is read from the file, it can be split on the commas so that the pieces of data are put in an array. The order of the data elements in the array will be the same order as they are listed in a record in a line.

```
var line = reader.ReadLine();
var values = line.Split(',');
```
Make sure the number of values obtained from a line is the expected number of values.

### Handline Errors
A well-written program should not crash regardless of the input or data provided to it. You should handle all exceptions and error conditions that arise when the program is run. If an exception or error occurs, it should be reported to the user and the program should exit.

If the user runs the program without providing the two command line parameters, then the program is to display a message to the user indicating how the program is to be run.

```
CrimeAnalyzer <crime_csv_file_path> <report_file_path>
```

The following are some of the errors that could occur that need to be handled. Note, there is no implication that these are all the possible errors. They are being provided to give you a sense of error conditions that could arise that need to be handled.

- CSV file can’t be opened.
- Error occurs reading lines from CSV file.
- Record doesn’t contain the correct number of data elements.
- Record contains data that is not of the right type. Note: All the data is numerical.
- Report file can’t be opened or written to.
When you display an error message to the user, be as specific as possible about the problem and where it occurred. For example, if a record is malformed the line number of the record in the file should be included in the message to the user along with any other info that could be helpful in finding and correcting the problem.

The following is an example of an error message to the user when the wrong number of values is encountered in a record.
```
$"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}."
```
### Using Language INtegrated Query (LINQ)
LINQ is very helpful in answering the questions provided below. To illustrate how LINQ works to help with this program, a LINQ statement is provided below to answer the question: What years is the number of rapes less than 85000?

```
var years = from crimeStats in crimeStatsList where crimeStats.Rape < 85000 select crimeStats.Year;
```

After the above line executes, years is a collection (IEnumerable) of the years that were found using the LINQ statement.

In the above LINQ, crimeStatsList is a variable referencing a List of instances of a class (in my case CrimeStats) that was created in the C# code before this LINQ statement. The instances of the class in the List holds the pieces of data from a row in CSV data for Population, ViolentCrime, Murder, Rape, etc. crimeStats in from crimeStats in crimeStatsList is a variable in the LINQ that refers to individual instances from the list of instances. So, instances of crimeStats are going to be gotten out of (from) crimeStatsList. The name crimeStats was chosen by me to indicate an instance from the list. The name can be any valid variable name. The where condition establishes which instances of crimeStats are to be included. In the above example, crimeStats.Rape < 85000 indicates instances of crimeStats for which the number of rapes is less than 85000 are to be included. Rape is a property of the CrimeStats class. crimeStats.Rape is the quantity of rapes for a given instance of CrimeStats. The select near the end determines what information is returned. select crimeStats.Year indicates that from the instances of CrimeStats, the Year property value is to be chosen. Since there is possibly more than one instance of CrimeStats that could meet the condition of the where clause, the result is an IEnumerable which means we can use foreach to iterate through the results collection.

The following is the way to iterate through an IEnumerable.

```
foreach (var year in years)
{
	Console.WriteLine(year);
}
```

### Questions
The questions to be answered by the application that are to be used as the basis of a report that the application generates are the following.

1. What is the range of years included in the data?
2. How many years of data are included?
3. What years is the number of murders per year less than 15000?
4. What are the years and associated robberies per year for years where the number of robberies is greater than 500000?
5. What is the violent crime per capita rate for 2010? Per capita rate is the number of violent crimes in a year divided by the size of the population that year.
6. What is the average number of murders per year across all years?
7. What is the average number of murders per year for 1994 to 1997?
8. What is the average number of murders per year for 2010 to 2013?
9. What is the minimum number of thefts per year for 1999 to 2004?
10. What is the maximum number of thefts per year for 1999 to 2004?
11. What year had the highest number of motor vehicle thefts?


### Example Report
Crime Analyzer Report

Period: 1994–2013 (20 years)

Years murders per year < 15000: 2010, 2011, 2012, 2013
Robberies per year > 500000: 1994 = 618949, 1995 = 580509, 1996 = 535594
Violent crime per capita rate (2010): 0.0040450234834638
Average murder per year (all years): 16864.25
Average murder per year (1994–1997): 20696.25
Average murder per year (2010–2014): 14608.75
Minimum thefts per year (1999–2004): 6937089
Maximum thefts per year (1999–2004): 7092267
Year of highest number of motor vehicle thefts: 1994
