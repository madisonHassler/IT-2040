/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        March 4, 2022
 * Module:      6
 * Challenge:   Project1
 ****************************************************************************/
using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your name:");
            string name = Console.ReadLine();
            
            string fileName = getFileName();

           Console.WriteLine(fileName);




        }



        /*function to get a filename from the user*/
        static string getFileName()
        {
            Console.WriteLine("Please enter the name of the file to be written: ");
            string fileName = Console.ReadLine();
            /*chekc if filename ends in .txt*/
            fileName = checkUserFileName(fileName);
            return fileName;
        }


        /*function to check and return filename ending in .txt*/
        static string checkUserFileName(string fileName)
        {
            /*check if filename ends in .txt*/
            if(fileName.EndsWith(".csv"))
            {
                return fileName;
            }else
            {
                return fileName + ".csv";
            }
        }


        

        
    }
}
