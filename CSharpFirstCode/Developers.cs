using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class Developers : Testers
    {
        public override void automationTeser()
        {
            Console.WriteLine("This method is override by deveopers ");
        }
        public void developingCode()
        {
            Console.WriteLine("Developers write the code");
        }
        public void design()
        {
            Console.WriteLine("Developers design the architect");
        }


      
    }
}
