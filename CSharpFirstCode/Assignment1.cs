using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class Assignment1
    {


        //this code is for addition funtion
        public double num1;
        public double num2;

        public double addition()
        {
            return num1 + num2;
        }

        public void display()
        {
            int num1, rem;
            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem = num1 % 2;

            if(rem== 0)
            {
                Console.WriteLine("Entered number {0} is even",num1);

            }
            else
            {
                Console.WriteLine("Entered number {0} is odd",num1);
            }


            //this is for addition function 
                        
                Console.WriteLine("Num1 is : {0}", num1);
                Console.WriteLine("Num2 is : {0}", num2);
                Console.WriteLine("Addition is : {0}", addition());
                
            
            Console.ReadKey();
        }
    }

    internal class squareArea
    {
        public static double calculateArea(double sidelength)
        {
            double area = sidelength * sidelength;
            return area;
        }

       
    }



    class executecode1
    {
        static void Main(string[] args)
        {
            //comment below code when try to run addition function
            Assignment1 as1 = new Assignment1();
            as1.display();


            int personAge;
            Console.WriteLine("Enter the person Age:");
            personAge = Convert.ToInt32(Console.ReadLine());
            switch (personAge)
            {
                case 18:
                    Console.WriteLine("You are not allowed to work");
                    break;

                case 36:
                    Console.WriteLine("You are allowed to work");
                    break;

                case 60:
                    Console.WriteLine("You are too old to work");
                    break;

                default: 
                    Console.WriteLine("Provide the actua age");
                    break;
            }


            //loops

            if (personAge > 18)
            {
                for(int i=0;i<=2;i++)
                {
                    Console.WriteLine("Eligible to vote in india");
                }
            }
            else if(personAge <= 18)
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Not Eligible to vote in india");
                }
            }



            // this is for addition function , when trying this, comment all above code in main
            Assignment1 as2 = new Assignment1();
            Console.WriteLine("Enter num1 :");
            
            as2.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            as2.num2 = Convert.ToInt32(Console.ReadLine());

            as2.display();
            Console.ReadKey();


            //This is for square area
            double length = 5.5;
            double area = calculateArea(length);


        }
    }
}
