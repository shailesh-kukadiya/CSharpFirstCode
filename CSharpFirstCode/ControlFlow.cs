using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class ControlFlow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my Second CSharp Code");

            String Expected = "Selenium";

            String envName = "Testenv";

            if (Expected == "Seleniumtesting")
            {
                Console.WriteLine("Correct code exceuted");
            }
            else
            {
                Console.WriteLine("No Execution");

            }

            if (envName == "Testenv")
            {
                Console.WriteLine("Test env launched");

            }
            else if (envName == "Devenv")
            {
                Console.WriteLine("Dev env launched");

            }
            else
            {
                Console.WriteLine("No env matched");

            }

            //write program to check the Pass or fail if te student overall % score is > 60 then it should pass else it should failed


            Double totalScore = 60;

            if (totalScore > 60)
            {
                Console.WriteLine("Pass");

            }
            else if (totalScore <= 60)
            {
                Console.WriteLine("Failed");

            }
            else
            {
                Console.WriteLine("Undefiend");

            }


            //switch condition (similar to else if but more faster than nested else if

            int envnum = 2;

            switch (envnum)
            {
                case 1:
                    Console.WriteLine("Dev env with switch case");
                    break;
                case 2:
                    Console.WriteLine("Test env with switch case");
                    break;
                default:
                    Console.WriteLine("No Match Found");
                    break;

            }


            int studentscore = 60;

            switch (studentscore)
            {
                case 60:
                    Console.WriteLine("Fail");
                    break;
                case 61:
                    Console.WriteLine("pass");
                    break;
                default:
                    Console.WriteLine("undefined");
                    break;

            }

            //loops
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("testig the for loop : " + i);
            }

            for (int j = 0; j <= 119; j++)
            {
                //Enter the month value
                //capture the value after entering
                //write the captured value in text on screen

            }


            int interest = 8;
            int result;






                int k = 0;
                //exit when k become more tha 4
                while (k <= 4)
                {
                    Console.WriteLine("testig the while loop : " + k);
                    k++;

                }


                //do while loop
                int l = 0;
                do
                {
                    Console.WriteLine("testig the do while loop : " + l);
                    l++;
                } while (l <= 5);



                Console.ReadLine();
            }

        }
    }
