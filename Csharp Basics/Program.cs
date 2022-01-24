/***************************************************************************** 
 * Author:      Madison Hassler
 * Pawprint:    mehfmd
 * Course:      INFOTC 2040
 * Semester:    Spring 2022
 * Date:        January 24, 2022
 * Module:      2
 * Challenge:   Csharp Basics
 ****************************************************************************/ 
using System;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte comperison of sample1 and sample2*/
             const byte sample1 = 0x3A;
             byte sample2 = 58;
            {
                if (sample1 == sample2)
                {
                    Console.WriteLine("The samples are equal.");
                } 
                else 
                {
                    Console.WriteLine("The samples are not equal.");
                }

            }


            /* if/else heartRate*/
            int heartRate = 85;
            {
                if (heartRate >= 40 && heartRate <= 80)
                {
                    Console.WriteLine("Heart rate is normal.");
                }
                else
                {
                    Console.WriteLine("Heart rate is not normal.");
                }
            }


            /*double deposits*/
            double deposits = 135002796;
            {
                if (deposits >= 100000000)
                {
                    Console.WriteLine("You are exceedingly wealthy.");
                }
                else
                {
                    Console.WriteLine("Sorry you are so poor.");
                }

            }


            /*float f = m*a */
            const float acceleration = 9.800f;
            float mass = 14.6f;
            float force = mass * acceleration;
            {
                Console.WriteLine($"force = {force}");
            }


            /* value of distance */
            double distance = 129.763001;
            {
                Console.WriteLine($"{distance} is the distance.");
            }


            /* lost and expensive = true*/
            bool lost = true;
            bool expensive = true;
            {

                if (lost == true && expensive == true)
                {
                    Console.WriteLine("I am really sorry! I will get the manager.");
                }
                else if (lost == false && expensive == false)
                {
                    Console.WriteLine("Here is coupon for 10% off.");
                }

            }


            /* switch/case with choice 1, 2, or 3*/
            int choice = 2;
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You chose 1.");
                        break;

                    case 2:
                        Console.WriteLine("You chose 2.");
                        break;

                    case 3:
                        Console.WriteLine("You chose 3.");
                        break;
                    
                    default:
                        Console.WriteLine("You made an unknown choice.");
                        break;
                }
            }


            /*display the integral”*/
            const char integral = '\u222B';
            {
                Console.WriteLine($"{integral} is an integral");
            }

            /*for loop from 5 to 10*/
            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine($"i = {i}");
            }



            /*while loop ages 0 to 5*/
            int age = 0;
            {
                while (age < 6)
                {
                    Console.WriteLine($"age = {age}", age);
                    age++;
                }

            }


            /*sting with Hello Karen*/
            const string greeting = "Hello";
            string name = "Karen";
            {
                Console.WriteLine(greeting + name);
            }
            
        }
    }
}

