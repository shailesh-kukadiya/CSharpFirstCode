using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is first csharp program");
            


            //variable
            int a = 1;
            int b= 2;
            int c;
            int x = 100;
            int y = 200;
            int results;
            bool re;
            int aa;
            float bb;
            //simple addition
            c = a + b;
            results = x + y;
            Console.WriteLine("This is sun=m :" + results);


            re = (a == b);
            Console.WriteLine("Equal operator :" + re);


            re = (a > b);
            Console.WriteLine("Greater operator :" + re);


            re = (a < b);
            Console.WriteLine("lessthan operator :" + re);


            re = (a >= b);
            Console.WriteLine("greater or equal to :" + re);

            re = (a != b);
            Console.WriteLine("not equal to :" + re);

            //re = aa && bb;
            //Console.WriteLine("And Operator : "+re);



            Console.WriteLine("Sum of two variable :"+c);

            Console.ReadKey();

        }
    }
}
