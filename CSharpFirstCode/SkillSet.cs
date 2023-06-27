using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class SkillSet
    {
        static void Main(string[] args)
        {
            //Testers obj= new Testers();
            //obj.automationTeser();
            //obj.manualTeser();
            //obj.PerformanceTeser();

            Developers devobj = new Developers();
            devobj.automationTeser();
            devobj.manualTeser();
            devobj.PerformanceTeser();
            devobj.developingCode();
            devobj.design();


        }
    }

 
}
