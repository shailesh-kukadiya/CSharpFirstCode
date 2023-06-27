using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFirstCode
{
    internal class SampleLogin
    {
        public string AppLaunch(string url)
        {
            string appurl;

            Console.WriteLine("Application launch");
            return url;
        }

        public string verifyPage(string pagetitle)
        {
            Console.WriteLine("Application launch");
            return pagetitle;
        }

        public string login(string uname, string pass)
        {
            Console.WriteLine("Application launch");
            return null;
        }



        static void Main(string[] args)
        {
            string url = "";
            string pagetitle = "";
            SampleLogin obj = new SampleLogin();
            obj.AppLaunch(url);
            obj.verifyPage(pagetitle);
           // obj.login(obj)

        }
    }
}
