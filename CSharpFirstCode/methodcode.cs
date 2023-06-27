using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSharpFirstCode
{
    internal class methodcode
    {
        public double Length;
        public double Width;

        public double RectGetArea()
        {
            return Length * Width;

        }

        public double SquareGetArea()
        {
            return Length / Width;

        }
        public void display()
        {
            Console.WriteLine("Length is : {0}", Length);
            Console.WriteLine("Width is : {0}", Width);
            Console.WriteLine("Area of rentangle is : {0}", RectGetArea());
            Console.WriteLine("Square root is : {0}", SquareGetArea());
        }
    }
    class executecode
        {
        static void Main(string[] args)
        {
            methodcode mcall = new methodcode();
            mcall.Length = 5.5;
            mcall.Width = 3.5;

            mcall.display();

        }

    }
       
    }

