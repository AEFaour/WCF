using ConsoleAppClientWS_Async.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClientWS_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            AppelWS();
            Console.ReadKey();
        }

        private async static void AppelWS()
        {
            Service1Client proxy = new Service1Client();
            Get_ValueRequest request = new Get_ValueRequest();
            request.i_NumValue = 1; // temp

            Get_ValueResponse _rep = await proxy.Get_ValueAsync(request);
            Console.WriteLine("Au " + _rep.s_DateValue + " " + _rep.s_DescValue + " est de: " + _rep.Get_ValueResult);
            proxy.Close();
        }
    }
}
