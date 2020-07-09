using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMeteoClient2.Model;
using System.Configuration;
using System.IO;

namespace WpfAppMeteoClient2.Helper
{
    class AccesFichier
    {
        public static List<Mesure> ChargerInfoMeteo()
        {
            List<Mesure> _liste = new List<Mesure>();

            // pour récupérer une info à partir du app.config, on utilise la configuarationMangager
            string _nomfic = ConfigurationManager.AppSettings["fic"];
            StreamReader stream = new StreamReader(_nomfic, Encoding.Default);
            string contenu = stream.ReadToEnd();
            string[] lignes = contenu.Split(Environment.NewLine.ToCharArray()[0]);

            for (int i = 0; i < lignes.Length; i++)
            {
                string[] _cellules = lignes[i].Split('=');
                // utiliser une clasee meteo
                if (_cellules.Length >= 2)
                {
                    Mesure mesure = new Mesure()
                    {
                        Id = int.Parse(_cellules[0]),
                        Libelle = _cellules[1]
                    };

                    // Ajout dans la liste
                    _liste.Add(mesure);
                }

            }
            return _liste;
        }
    }
}
