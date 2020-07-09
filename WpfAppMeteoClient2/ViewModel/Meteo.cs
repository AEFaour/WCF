using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMeteoClient2.Helper;
using WpfAppMeteoClient2.Model;

namespace WpfAppMeteoClient2.ViewModel
{
    public class Meteo
    {
        // Utiliser une collection Obervable pour toute liste sur laquelle on peut vaaire du binding

        static ObservableCollection<Mesure> mesure;

        static ObservableCollection<Mesure> Mesures
        {
            set { mesure = value; }
            get { return mesure; }
        }
        // Le contructeur
        public Meteo()
        {
            if (mesure == null)
            {
                // A chaque fois qu'on veut aider par une méthode pour faire une tache 
                // Cette méthode doit être créer dans un namespace Helper -- Utils

                mesure = new ObservableCollection<Mesure>(AccesFichier.ChargerInfoMeteo());

            }
        }
    }
}
