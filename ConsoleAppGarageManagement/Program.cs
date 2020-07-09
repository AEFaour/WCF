using ConsoleAppGarageManagement.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGarageManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeVoitures();
        }

        private static void ListeVoitures()
        {
            ServiceReference1.Service1Client cli = new ServiceReference1.Service1Client();
            List<Voiture> voitures = cli.ListVoitures().ToList();
        }
    }
}
