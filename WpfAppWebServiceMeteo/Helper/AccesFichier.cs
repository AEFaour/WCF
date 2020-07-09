using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWebServiceMeteo.Model;

namespace WpfAppWebServiceMeteo.Helper
{
    class AccesFichier
    {
        public static List<Meteo> ChargerInfoMeteo()
        {
            List<Meteo> _liste = new List<Meteo>();

            // pour récupérer une info à partir du app.config, on utilise la configuarationMangager
            string _nomfic = ConfigurationManager.AppSettings["fic"];
            StreamReader stream = new StreamReader(_nomfic, Encoding.Default);
            string contenu = stream.ReadToEnd();
            string[] lignes = contenu.Split('\n');

            for (int i = 0; i < lignes.Length; i++)
            {
                string[] _cellules = lignes[i].Split('=');
                // utiliser une clasee meteo
                if (_cellules.Length >= 2)
                {
                    Meteo meteo = new Meteo()
                    {
                        Id = int.Parse(_cellules[0]),
                        Libelle = _cellules[1]
                    };

                    // Ajout dans la liste
                    _liste.Add(meteo);
                }

            }
            return _liste;
        }
    }

}
