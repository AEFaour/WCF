using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWebServiceMeteo.Helper;
using WpfAppWebServiceMeteo.Model;

namespace WpfAppWebServiceMeteo.ViewModel
{
    public class GestionMeteo
    {
        // Utiliser une collection Obervable pour toute liste sur laquelle on peut vaaire du binding

        static ObservableCollection<Meteo> meteo;

        static ObservableCollection<Meteo> Meteos
        {
            set { meteo = value; }
            get { return meteo; }
        }
        // Le contructeur
        public GestionMeteo()
        {
            if (meteo == null)
            {
                // A chaque fois qu'on veut aider par une méthode pour faire une tache 
                // Cette méthode doit être créer dans un namespace Helper -- Utils

                meteo = new ObservableCollection<Meteo>(AccesFichier.ChargerInfoMeteo());
            }
        }
    }
}
