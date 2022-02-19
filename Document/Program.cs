/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        February 18, 2022
 * Module:      5
 * Challenge:   Document
 ****************************************************************************/
using System;
using System.IO;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            int restartCount = 0;

            Console.WriteLine("Document\n");
           
           while(restart)
           {
                /*Ask user for filename*/
                string file = getFileName();
                Console.WriteLine($"\nFilename: {file}");

                
                /*write  data to the file*/
                writeDataToFile(file);

                /*restarting loop*/
                Console.WriteLine("\n\nTo create another file, type 'y'. Type any other key to exit.");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    restartCount++;
                }
                else
                {
                    restart = false;
                }
           }
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
            if(fileName.EndsWith(".txt"))
            {
                return fileName;
            }else
            {
                return fileName + ".txt";
            }
        }



        /*function to get data, write to file, and count words*/
        static void writeDataToFile(string fileName)
        {
            /*create a stream writer object*/
            StreamWriter fileWriter = File.AppendText(fileName);
            Console.WriteLine("\n\nEnter the content that is to be written in the document: ");
            string fileData = Console.ReadLine();

            /*split into words and get length*/
            string[] wordCount = fileData.Split(' ');
            int numberOfWords = wordCount.Length;
            try
            {
                fileWriter.WriteLine(fileData);
                fileWriter.Close();
                Console.WriteLine($"\n\n{fileName} was successfully saved. The document contains {numberOfWords} words.");
            }catch(Exception err)
            {
                Console.WriteLine($"Exception Occurred: {err.Message}");
            }
        }



        /*function to read file contents and print them*/
        static void readAndPrintFileContents(string fileName)
        {
            StreamReader fileReader = new StreamReader(fileName);
            try
            {
                while(!fileReader.EndOfStream)
                {
                    string lineOfData = fileReader.ReadLine();
                    Console.WriteLine(lineOfData);
                }
                fileReader.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine($"Exception Occurred: {err.Message}");
            }
        }
    }
}
