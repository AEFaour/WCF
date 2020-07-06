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
            InfoMeteo2();
            Console.WriteLine("Fin de traitement");
            Console.ReadKey();
        }

        private static void InfoMeteo2()
        {
            // Exercie : Utiliser la méthode getValue pour afficher la temparature 
            Service1Client client = new Service1Client();
            MeteoData meteo = client.Get_MeteoData();
            Console.WriteLine("Temparature relévé (Méthode Get_MeteoData()) : " + meteo.d_Temp);
            string _dateVale, _descVal;
            string _res = client.Get_Value(1, out _dateVale, out _descVal);
            Console.WriteLine("Temparature relévé (Méthode Get_Value()): " + _res);
            _res = client.Get_Value(2, out _dateVale, out _descVal);
            Console.WriteLine("Au " + _dateVale + " La " + _descVal + "est de " + _res);
            // Via WPF Permettre à l'utlisateur de choisir i_NumVal via un Comobox 
            // En fonction de son choix : Afficher les infos : Date_Val et DescVal
            client.Close();
        }

        private static void InfoMeteo1()
        {
            // instancier le ws -->créer le proxy (ou le client)
            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            // ou bien faire using de NameSpace
            Service1Client client = new Service1Client();
            MeteoData meteo = client.Get_MeteoData();
            Console.WriteLine("date relevé : " + meteo.dt_Releve + " " + meteo.s_VentDirStr + " " + meteo.d_Pres);
            client.Close();
        }
    }
}
