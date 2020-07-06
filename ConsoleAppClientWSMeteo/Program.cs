using ConsoleAppClientWSMeteo.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClientWSMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début de traitement");
            InfoMeteo1();
            Console.WriteLine("Fin de traitement");
            Console.ReadKey();
        }

        private static void InfoMeteo1()
        {
            // instancier le ws -->créer le proxy (ou le client)
            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            // ou bien faire using de NameSpace
            Service1Client client = new Service1Client();
            MeteoData meteo = client.Get_MeteoData();
            Console.WriteLine("date relevé " + meteo.dt_Releve + " " + meteo.s_VentDirStr + " " + meteo.d_Pres);
        }
    }
}
