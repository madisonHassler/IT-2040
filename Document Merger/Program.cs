/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        February 25, 2022
 * Module:      6
 * Challenge:   Document Merger
 ****************************************************************************/
using System;
using System.IO;

namespace Document_Merger
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            int restartCount = 0;

            Console.WriteLine("Document Merger\n");

            while(restart)
            {
            
                /*calls function to prompt user to enter a valid document name*/
                string docName1 = getDocumentName();
                string docName2 = getDocumentName();

                /*prompts user if they want to enter their own doument name or merges
                document 1 name with document 2 but takes off the .txt from both*/
                string mergeDocName = mergeDocumentNameChoice(docName1, docName2);

                /*reads text from both files and makes them a string*/
                string lineOfData = readFileText1(docName1);
                string lineOfData2 = readFileText2(docName2);

                /*writes both strings from documents to new merged file*/
                writeNewMergeFile(mergeDocName, lineOfData, lineOfData2);

                /*restarting loop*/
                Console.WriteLine("\n\nWould you like to merge two more documents? (y/n)?");
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
        /************END OF MAIN*************/


        /*get file name and check if it exists*/
        static string getDocumentName()
        {
            string docName;
            while(true)
            {
                Console.WriteLine("Enter the name of the document");
                docName = Console.ReadLine();
                string newDocName = checkDocumentName(docName);
                
                if(newDocName == "" || !File.Exists(newDocName))
                {
                    Console.WriteLine("Error: You must enter valid document name.\n");
                    continue;
                }else
                {
                    break;
                }
            }
            return checkDocumentName(docName);
        }


        /*add .txt to end of file*/
        static string checkDocumentName(string documnetName)
        {
            if(documnetName.EndsWith(".txt"))
            {
                return documnetName;
            }else
            {
                return documnetName + ".txt";
            }
        }


        /*create a new merged file and write data to it*/
        static void writeNewMergeFile(string mergeDocName, string lineOfData, string lineOfData2)
        {
          StreamWriter fileWriter = new StreamWriter(mergeDocName);
            try
            {
                fileWriter.Write(lineOfData);
                fileWriter.Write("\n");
                fileWriter.Write(lineOfData2);
                fileWriter.Close();
            }catch(Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
            }finally
            {
                if (fileWriter != null)
                {
                    fileWriter.Close();
                }
                    /*calls function to get the number of words*/
                    int numbWord = getWordCount(mergeDocName);
                    Console.WriteLine($"\n{mergeDocName} was successfully saved. The document contains {numbWord} words.");
            }
        }

        /*read text from first file and return it as a string*/
       static string readFileText1(string docName1)
       {
            StreamReader srDoc1 = new StreamReader(docName1);
            try
            {
                string lineOfData = srDoc1.ReadToEnd();
                srDoc1.Close();
                return lineOfData;
            }catch(Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
                return null;
            }finally
            {
                if (srDoc1 != null)
                {
                    srDoc1.Close();
                }
            }
       }


        /*read text from second file and return it as a string*/
       static string readFileText2(string docName2)
       {
           StreamReader srDoc2 = new StreamReader(docName2);
           try
            {
                string lineOfData2 = srDoc2.ReadToEnd();
                srDoc2.Close();
                return lineOfData2;

            }catch(Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
                return null;
            }finally
            {
                if (srDoc2 != null)
                {
                    srDoc2.Close();
                }
            }
       }


        /*read all text from merged file and return the number of words*/
        static int getWordCount(string mergeDocName)
        {
            StreamReader srMerge = new StreamReader(mergeDocName);
           try
            { 
                string mergeText = srMerge.ReadToEnd();
                //split the document content at the spaces " " to get the words
                string[] words = mergeText.Split(" ");
                return words.Length;

            }catch(Exception err)
            {
                /*If an exception occurs, output the exception message and exit.*/
                Console.WriteLine("Exception: " + err.Message);
                return 0;
            }finally
            {
                if (srMerge != null)
                {
                    srMerge.Close();
                }
            }
        }


        static string mergeDocumentNameChoice(string docName1, string docName2)
        {
            Console.WriteLine("Would you like to enter a custom name for your new document? (y/n)?");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                string mergeName = docName1.Substring(0, docName1.Length - 4) + docName2.Substring(0, docName2.Length - 4);
                string mergeDocName = checkDocumentName(mergeName);

                return mergeDocName;
            }else
            {
                Console.WriteLine("Please enter the new name:");
                string enterDocName = Console.ReadLine();
                string mergeDocName = checkDocumentName(enterDocName);

                return mergeDocName;
            } 

        }
        /****end of class****/
    }
}

       