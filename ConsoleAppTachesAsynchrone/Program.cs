using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTachesAsynchrone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début de main");
            // Taches Asynchrones
            Task task = new Task(() => MethodeA());
            task.Start();

            Console.WriteLine("\n Fin  de main");
            Console.ReadLine();


        }
        private async static void MethodeA()
        {
            Console.WriteLine("\n Début de la méthode");
            Task t1 = new Task(() => MethodeB());
            t1.Start();
            //MethodeB();
            // Et s'on a besoin la fin d'execution de la méthode B pour continuer le traitement ? 
            // pour céla on utlise les async et await
            await MethodeCAsync();
            Console.WriteLine("\n Fin de la méthode");
        }

        private async static Task MethodeCAsync()
        {
            Console.WriteLine("\n \n Début traitement C ...");
            Thread.Sleep(4000); // L'occuper pour 5 s
            Console.WriteLine("\n \n Fin traitement C ...");
        }

        private static void MethodeB()
        {
            Thread.Sleep(5000); // L'occuper pour 5 s
            Console.WriteLine("\n \n Autres traitements ...");
        }
    }
}
