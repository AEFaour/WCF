using ConsoleAppInterAgitAvecPremierWS.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterAgitAvecPremierWS
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 5);
            Soustruc(5, 1);
            Multi(9, 8);
            Divis(20, 4);
            Console.ReadLine();
        }

        private async static void Multi(int v1, int v2)
        {
            Service1Client client = new Service1Client();
            int multi = await client.MultiplicationAsync(v1, v2);
            Console.WriteLine("La multiplication de {0} et {1} est {2}", v1, v2, multi);
            client.Close();
        }

        private async static void Divis(int v1, int v2)
        {
            Service1Client client = new Service1Client();
            decimal div = await client.DivisionAsync(v1, v2);
            Console.WriteLine("La Division de {0} et {1} est {2}", v1, v2, div);
            client.Close();
        }

        private async static void Soustruc(int v1, int v2)
        {
            Service1Client client = new Service1Client();
            int sous = await client.SoustractionAsync(v1, v2);
            Console.WriteLine("La soustraction de {0} et {1} est {2}", v1, v2, sous);
            client.Close();
        }

        private async static void Add(int v1, int v2)
        {
            Service1Client client = new Service1Client();
            int s = await client.AdditionAsync(v1, v2);
            Console.WriteLine("La somme de {0} et {1} est {2}", v1, v2, s);
            client.Close();
        }
    }
}
