using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            Console.WriteLine("This is using for loop in array : \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //
            Console.WriteLine("\nThis is using FOR EACH.\n");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //defining array with values syntax
            int[] arr2 = {1,2,3,4};



            String str1 = "  Testing the Seleniium ";
            Console.WriteLine(str1.Trim());

            String str2 = "Testing";
            String str3 = "Testing";
            String str4 = "Selenium";
            String str5 = "automat";
            String str66 = "tingTest";
                
            Console.WriteLine(string.Compare(str2,str3));
            Console.WriteLine(string.CompareOrdinal(str2,str66));

            String str6 = "Selenium with C Sharp";
            String[] str7= str6.Split(' ');

            Console.WriteLine(str6);
            foreach (String str8 in str7)
            {
                Console.WriteLine(str8);
            }

            int Index1 = str6.IndexOf("i");
            Console.WriteLine("First Letter 'i' is at position :" + Index1);

            int Index = str6.LastIndexOf("i");
            Console.WriteLine("Last Letter 'i' is at position :"+Index);

            String str11 = "#Testing the Seleniuim";
            Console.WriteLine(str11.TrimStart('#'));
            Console.WriteLine(str11.TrimEnd('#'));


            //int a = 10;
            //int b = 0;
            //int c = a / b;
            //Console.WriteLine("Exception before this and code from this line will not be executed due to this.");

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("Exception before this and this is in try blok");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred");
            }
            finally
            {
                Console.WriteLine("mandatory to be executed to be put in finally");
            }

            Console.WriteLine("Exception before this code but all the lines after exception will be executed.");



        }
    }
}
