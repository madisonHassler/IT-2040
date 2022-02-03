/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        February 4, 2022
 * Module:      3
 * Challenge:   GradeConverter
 ****************************************************************************/ 
using System;
using System.Collections.Generic;


namespace GradeConverter
{
    class Program
    {


        static void Main(string[] args)
        {

            bool restart = true;
            int restartCount = 0;
            /*while loop to restart the program if conditions are true*/
            while(restart)
            {


            /*Ask for First Name*/
            Console.WriteLine("Enter your first name: ");
            String firstName = Console.ReadLine();

            /*Ask for Last Name*/
            Console.WriteLine("\nEnter your last name: ");
            String lastName = Console.ReadLine();

            /*Welcome message with First and Last Name*/
            Console.WriteLine($"\nHello {firstName} {lastName} Welcome to the Grade Converter!");



            /*create a list*/
            List<double> numbers = new List<double>();

            double userValue;
            int gradeNumber = getNumberOfGrades(); 

            /*add numbers to list based on user input*/
            for(double value = 0; value < gradeNumber; value ++)
            {
                userValue = getNumber();
                numbers.Add(userValue);
            }

            /*print the values from that list and covert to letter grade*/
            Console.WriteLine("\n\nNumber score to letter grade conversion:");
            foreach(double item in numbers)
            {
                string letterGrade = convertNumber(item);
                Console.WriteLine($"A score of {item} is a {letterGrade} grade");

            }

        
            /*grade stats*/
            Console.WriteLine("\nGrade Statistics");
            Console.WriteLine("--------------------------");
            
            
            /*calculate average of all grades in list*/
            int amt = numbers.Count;
            double total = 0;
            foreach(double item in numbers)
            {
               total += item;
            }
            double average = total / amt;

            Console.WriteLine($"Number of grades: {amt}");
            Console.WriteLine($"Average Grade: {average}, which is a {convertNumber(average)}");


            Console.WriteLine("\n\nWould you like to convert more grades, yes or no?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                restartCount++;
            }
            else{
                restart = false;
                }
            }

        }
        /********************************END OF MAIN******************************************/




        /*function to get value from console and convert to integer and store to be used for list*/
        static int getNumberOfGrades()
        {
            int gradeNumber;
            
            while(true){
            try
            {
                Console.WriteLine("\n\nEnter the number of grades you need to convert: ");

                gradeNumber = int.Parse(Console.ReadLine());
                break;
                
            }catch(Exception)
            {
                Console.WriteLine("\n\nERROR: Only numerical values are accepted.");

                }
            }
            return gradeNumber;
        }


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


        /*code shown in class on 2/1/2022 for function that prompts user to enter grades and add to list*/
        static double getNumber()
        {
            double userValue;
           
           while(true){
            try
            {
                /*prompt user for value*/
                Console.WriteLine("Enter Grade: ");
                /*get value from console and convert to double type*/
                userValue = double.Parse(Console.ReadLine());
                /*only accepts values 0-100*/
                if (userValue <0 || userValue >100){
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

    }
}