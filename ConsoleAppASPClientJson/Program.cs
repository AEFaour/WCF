using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplicationASPWebService.Models;

namespace ConsoleAppASPClientJson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ajout Json via ws
            AjoutAbonneWS();
            Console.ReadLine();
        }

        private static void AjoutAbonneWS()
        {
            // Ajouter un client Http
            var client = new HttpClient();
            Console.WriteLine("Création du client http");
            // Poste un objetSon en asynchrone via une URL
            string _server = ConfigurationManager.AppSettings["server"];
            Console.WriteLine("Connexion au serveur : " + _server + ".....");
            Console.WriteLine("\n Entree pour continuer ");
            Console.ReadLine();

            var result = client.PostAsJsonAsync(_server, new Abonne()
            { Prenom = "Prenom Client Http", Mail = "Mail Client Http", Telephone = "0268956644" }
             ).Result;
            Console.WriteLine("Mise à jour envoyé vers le serveur");
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);

        }
    }
}
