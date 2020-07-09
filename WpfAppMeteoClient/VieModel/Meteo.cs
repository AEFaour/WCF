using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMeteoClient.Helper;
using WpfAppMeteoClient.Model;

namespace WpfAppMeteoClient.VieModel
{
    public class Meteo
    {


        // Utiliser une collection oBservable pour toute liste sur laquelle
        //On veut faire du binding.

        private static ObservableCollection<Mesure> mesure;
        public static ObservableCollection<Mesure> Mesures
        {
            set { mesure = value; }
            get { return mesure; }

        }

        // Le constructeur
        public Meteo()
        {
            if (mesure == null)
            {                // A chaque fois qu'on veut aider par une méthode pour faire une tache
                // Cette méthode doit etre créer dans un namaespace Helper -- Utils

                mesure = new ObservableCollection<Mesure>(AccesFichier.ChargerInfoMeteo());
            }
        }
    }
}
