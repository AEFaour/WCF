using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using WpfAppGestionGarageManagement.HelperWS;
using WpfAppGestionGarageManagement.ServiceReference1;

namespace WpfAppGestionGarageManagement.ViewModel
{
    public class GestionVoiture
    {
        // Pas de DBContext
        private static ObservableCollection<Voiture> voitures;
        public static ObservableCollection<Voiture> Voitures
        {
            get => voitures;
            set => voitures = value;
        }

        public GestionVoiture()
        {
            // Mettre à jour la liste à partir de la database derrière le Web Service
            if (voitures == null)
            {
                voitures = new ObservableCollection<Voiture>(AccesWS.GetVoituresFromWS());
            }


        }
        public static int ajoutVoiture(Voiture voiture)
        {
            int ret = -1;
            ret = AccesWS.ajoutVoiture(voiture);
            if (ret > 0)
            {
                voitures.Add(voiture);
            }
            return ret;
        }
    }
}
