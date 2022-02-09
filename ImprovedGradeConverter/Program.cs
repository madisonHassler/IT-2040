/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        February 11, 2022
 * Module:      4
 * Challenge:   ImprovedGradeConverter
 ****************************************************************************/ 
using System;
using System.Collections.Generic;

namespace ImprovedGradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            bool restart = true;
            int restartCount = 0;
            string message;

            /*print welcome message from function*/
            message = welcome();

            /*while loop to restart the program if conditions are true*/
            while(restart)
            {
                int gradeNumber = getNumberOfGrades();
                
                List<double> numbers = new List<double>();
                numbers = populateGradesList(numbers, gradeNumber);
               
                /*print the values from that list and covert to letter grade*/
                Console.WriteLine("\n\nNumber score to letter grade conversion:");
                double print = printGrades(numbers, gradeNumber);

                
                /*grade stats*/
                Console.WriteLine("\nGrade Statistics");
                Console.WriteLine("--------------------------");
                
               
                double avgGrade = average(numbers);
                double maxGrade = maximum(numbers);
                double minGrade = minimum(numbers);
               

                Console.WriteLine("\n\nWould you like to convert more grades? Enter: yes or no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    restartCount++;
                }
                else
                {
                    restart = false;
                }
            }

        }
/******************************** END OF MAIN ******************************************/



/********************************** User Name ******************************************/
        static string welcome()
        {
            /*Ask for First Name*/
            Console.WriteLine("Enter your first and last name: ");
            String userName = Console.ReadLine();

            /*Welcome message with First and Last Name*/
            Console.WriteLine($"\nHello {userName}! Welcome to the Grade Converter!");
        
            return userName;
        }


 /************************************** Enter Number of Grades *******************************************/

        /*function to get value from console and convert to integer and store to be used for list*/
        static int getNumberOfGrades()
        {
            int gradeNumber;
            
            while(true)
            {
                Console.WriteLine("\n\nEnter the number of grades you need to convert: ");
                
                try
                {
                    gradeNumber = int.Parse(Console.ReadLine());
                    //number of can't be negative
                    if(gradeNumber < 0)
                {
                    Console.WriteLine("Error: Value must be 0 or greater");
                    continue;
                }
                    break;
                }
                catch(Exception)
                {
                    Console.WriteLine("\n\nERROR: Only numerical values are accepted.");
                }
            }
            return gradeNumber;
        }


/*************************************** Add to List ***************************************************/
        static List<double> populateGradesList(List<double> scoreList, int numGrades)
        {
            double userValue;
            /*add numbers to list based on user input*/
            for(double value = 0; value < numGrades; value ++)
            {
                userValue = getNumber();
                scoreList.Add(userValue);
            }
            return scoreList; 
        }


 /************************************* Enter Grades *********************************************/

        /*function that prompts user to enter grades*/
        static double getNumber()
        {
            double userValue;
           
           while(true)
           {
               try
               {
                   /*prompt user for value*/
                    Console.WriteLine("Enter Grade: ");
                    /*get value from console and convert to double type*/
                    userValue = double.Parse(Console.ReadLine());
                    /*only accepts values 0-100*/
                    if (userValue <0 || userValue >100)
                    {
                        Console.WriteLine("ERROR: Only values from 0 to 100 are accepted");
                        continue;
                    }
                        break;
                }catch(Exception)
                {
                    Console.WriteLine("ERROR: Only numerical values are accepted.");
                }
            }
            return userValue;
           
        }


/*************************************** Grade Conversion ******************************************/
        /*if/else funtion to convert number to letter grade*/
        static string convertNumber(double item)
        {
            string grade = "";
            if (item >= 90){
                grade = "A";
            }else if (item >= 80 && item <= 90){
                grade = "B";
            }else if (item >= 70 && item <= 80){
                grade = "C";
            }else if (item >= 60 && item <= 70){
                grade = "D";
            }else{
                grade = "F";
            }

            return grade;
        }


/*********************************** Print Grades ************************************************/
        static double printGrades(List<double> numbers, double grade)
        {
            
            foreach(double item in numbers)
            {
                string letterGrade = convertNumber(item);
                Console.WriteLine($"A score of {item} is a {letterGrade} grade");
                
            }
            return grade;
        }



/******************************************** Maximum *****************************************************/

        static double maximum(List<double> numbers)
        {
            double max = 0;
            foreach(double item in numbers)
            {
                if(item > max)
                {
                    max = item;
                }

            }

            Console.WriteLine($"Maximum: {max}");
            return max;
        }

/******************************************** Minimum *****************************************************/

        static double minimum(List<double> numbers)
        {
            double min = 101;
            foreach(double item in numbers)
            {
                if(item < min)
                {
                    min = item;
                }

            }

            Console.WriteLine($"Minimum: {min}");
            return min;
        }

/******************************************** Average *****************************************************/

        static double average(List<double> numbers)
        {
            int amt = numbers.Count;
            double total = 0;
            foreach(double item in numbers)
            {
                total += item;
            }
            
            double average = total / amt;

            Console.WriteLine($"Number of grades: {amt}");
            Console.WriteLine($"Average Grade: {average}, which is a {convertNumber(average)}");

            return average;
        }
    
        /***** END OF CLASS ****/
    }
}