/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        March 4, 2022
 * Module:      7
 * Challenge:   Project1
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;



namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*prompt user for name and store it for later*/
            Console.WriteLine("Hello, please enter your name:");
            string name = Console.ReadLine();


            /*ask user for file name and then check if .csv is appended*/
            string fileName = getFileName();


            Console.WriteLine($"\n\nHello {name}.\n");
            Console.WriteLine($"Welcome to the Payroll Processing Application\n");
            Console.WriteLine("-------------------------------------------\n");


            string firstName = "";
            string lastName = "";
            int hoursWorked = 0;
            float payRate = 0;
            float totalPay = 0;

            /*crate list that each total pay will be saved to*/
            List<float> payList = new List<float>();

            /*call function that splits data and add pay to list*/
            var data = readData(fileName, firstName, lastName, hoursWorked, payRate, totalPay, payList);

            /*write pay summary to new file*/
            writeSymmary(payList);
        }



        /*get file name and check if it exists*/
        static string getFileName()
        {
            string fileName;
            while (true)
            {
                Console.WriteLine("\nEnter payroll file name to be processed:");
                fileName = Console.ReadLine();
                string newDocName = checkUserFileName(fileName);


                /*if user doesnt enter anything or the file doesnt exists, does not exit while loop.
                if user enters the correct file that exists, then exits the while loop*/
                if (newDocName == "" || !File.Exists(newDocName))
                {
                    Console.WriteLine("Error: You must enter valid payroll name.\n");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return checkUserFileName(fileName);
        }


        /*function to check and return filename ending in .csv*/
        static string checkUserFileName(string fileName)
        {
            /*check if filename ends in .txt*/
            if (fileName.EndsWith(".csv"))
            {
                return fileName;
            }
            else
            {
                return fileName + ".csv";
            }
        }


        /*function to read file text, split data into an array, assign parts of the array 
        to different variables, and add total pay to a list*/
        static Tuple<string, string, int, float, float> readData(string fileName, string firstName, string lastName, int hoursWorked, float payRate, float totalPay, List<float> payList)
        {
            StreamReader fileReader = new StreamReader(fileName);

            try
            {
                while (!fileReader.EndOfStream)
                {
                    /*read the next line from the file*/
                    string lineOfData = fileReader.ReadLine();

                    /*split the line at the comma*/
                    string[] data = lineOfData.Split(",");

                    /*get data from the data array*/
                    firstName = data[0];
                    lastName = data[1];
                    hoursWorked = int.Parse(data[2]);
                    payRate = float.Parse(data[3]);

                    /*call function to calculate the total pay*/
                    totalPay = getTotal(hoursWorked, payRate);

                    /*add total pay to a list*/
                    payList.Add(totalPay);


                    Console.WriteLine($"{firstName} {lastName}: {totalPay:C}");

                }
                fileReader.Close();
            }
            catch (Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
            }
            finally
            {
                if (fileReader != null)
                {

                    fileReader.Close();

                }
            }
            return Tuple.Create(firstName, lastName, hoursWorked, payRate, totalPay);
        }



        /*function to calculate pay for all workers*/
        static float getTotal(float hoursWorked, float payRate)
        {
            float totalPay = 0;
            /*calculate total pay by multiplying number of hours worked with the pay rate*/
            totalPay = +hoursWorked * payRate;
            return totalPay;
        }



        /*function to calculate the total of all pay*/
        static float grandTotalPay(List<float> payList)
        {
            float grandTotal = 0;
            foreach (float pay in payList)
            {
                grandTotal += pay;
            }
            return grandTotal;
        }



        /*function to calculate the average total pay*/
        static float getAveragePay(List<float> payList)
        {
            float grandTotal = 0;
            foreach (float pay in payList)
            {
                grandTotal += pay;
            }
            return (grandTotal / payList.Count);
        }



        /*function to calculate the minimum pay*/
        static float getMinimumPay(List<float> payList)
        {
            float minScore = payList[0];
            foreach (float pay in payList)
            {
                if (pay < minScore)
                {
                    minScore = pay;
                }
            }
            return minScore;
        }



        /*function to calculate the maximume pay*/
        static float getMaximumPay(List<float> payList)
        {
            float maxScore = payList[0];
            foreach (float pay in payList)
            {
                if (pay > maxScore)
                {
                    maxScore = pay;
                }
            }
            return maxScore;
        }



        /*function to create summary and add data to it*/
        static void writeSymmary(List<float> payList)
        {
            StreamWriter fileWriter = new StreamWriter("salarySummary.txt");
            try
            {
                /*call functions to calculate the max, min, avg, and total*/
                float min = getMinimumPay(payList);
                float max = getMaximumPay(payList);
                float avg = getAveragePay(payList);
                float total = grandTotalPay(payList);
                int employees = payList.Count; /*counting the number of pays that are on the paylist in order to get the number of employees*/

                /*write all data to new file*/
                fileWriter.Write("Payroll Summary\n");
                fileWriter.Write("---------------\n");
                fileWriter.Write($"Number of Employees Paid: {employees}\n");
                fileWriter.Write($"Total Payroll: {total:C}\n");
                fileWriter.Write($"Average Salary: {avg:C}\n");
                fileWriter.Write($"Maximum Salary: {max:C}\n");
                fileWriter.Write($"Minimum Salary: {min:C}");
                fileWriter.Close();
            }
            catch (Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
            }
            finally
            {
                if (fileWriter != null)
                {
                    fileWriter.Close();
                }

                Console.WriteLine($"\nThe salarySummary.txt file was successfully saved.");
            }
        }
    }
}
