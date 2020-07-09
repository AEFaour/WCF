using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMeteoClient.Model;

namespace WpfAppMeteoClient.Helper
{
    class AccesFichier
    {


        public static List<Mesure> ChargerInfoMeteo()
        {
            List<Mesure> _liste = new List<Mesure>();

            // Pour récupérer une info à partir du app.config, on utilise le ConfigurationManager
            string _nomfic = ConfigurationManager.AppSettings["fic"];
            StreamReader stream = new StreamReader(_nomfic, Encoding.UTF8);
            string contenu = stream.ReadToEnd();
            string[] lignes = contenu.Split(Environment.NewLine.ToCharArray()[0]);
            for (int i = 0; i < lignes.Length; i++)
            {
                string[] _cellules = lignes[i].Split('=');
                // utiliser une classe Mesure ....
                if (_cellules.Length >= 2)

                {
                    Mesure mesure = new Mesure()
                    {
                        Id = int.Parse(_cellules[0]),
                        Libelle = _cellules[1]

                    };
                    //Ajout dans la liste
                    _liste.Add(mesure);
                }

            }

            return _liste;
        }

    }
}
