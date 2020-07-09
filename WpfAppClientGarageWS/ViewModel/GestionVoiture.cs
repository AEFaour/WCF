using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppClientGarageWS.HelperWS;
using WpfAppClientGarageWS.ServiceReference1;

namespace WpfAppClientGarageWS.ViewModel
{
    public class GestionVoiture
    {
        // Pas de DbContext
        private static ObservableCollection<Voiture> voitures;

        public static ObservableCollection<Voiture> Voitures
        {
            get => voitures;   // <=> get { return voitures; }
            set => voitures = value; //  <=> set { voitures = value; }
        }

        public GestionVoiture()
        {
            // Mettre à jour la liste à partir de la base derrière le Web Service

            if (voitures == null)
                voitures = new ObservableCollection<Voiture>(AccesWS.GetVoituresFromWS());
        }


        public static int AjoutVoiture(Voiture voiture)
        {
            int ret = -1;
            ret = AccesWS.AjoutVoitureWS(voiture);

            if (ret > 0) voitures.Add(voiture);
            return ret;

        }
    }
}
