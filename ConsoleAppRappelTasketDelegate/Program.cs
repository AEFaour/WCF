using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRappelTasketDelegate
{
    class Program
    {
        // Les delegates 
        // Un delegate est un type pour les méthodes : ( pointeur sur les méthodes) 

        delegate void Notifier(int i);
        static void Main(string[] args)
        {
            //List<int> _l = MethodeTresLongue();
            //foreach (var item in MethodeTresLongue())
            //{
            //    //toDo list
            //    Console.WriteLine(item);
            //}
            // Le travail  ligne 18   ne peut se faire que si la méthode a fini son travail - qu'elle a retourné la liste 
            // et Enfin qu'on parcour la liste 

            // N'est-il pas possible de récupérer les infos qu-fur et à mesure qu'elles sont lues depuis la base

            // OUI et pour celà on va utiliser un delegate qui va nous notifier de l'arrivée de ces infos
            MethodeTresLongue(x => Console.WriteLine(x));
            // Le delegate est utliser pour faire du callBack
            Console.ReadLine();
        }

        private static List<int> MethodeTresLongue(Notifier Refresh)
        {
            // retourne très longue liste lue à partir d'un BD ou WS
            List<int> _listInt = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                Refresh(i);
                _listInt.Add(i);
            }
            //return _listInt;
            return null;
        }
    }
}
