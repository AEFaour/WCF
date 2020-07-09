using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceGarage.Model;
using WcfServiceGarage.ViewModel;

namespace WcfServiceGarage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WSGarage" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WSGarage.svc ou WSGarage.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WSGarage : IWSGarage
    {
        private static EFGarage dtc = new EFGarage();
        public int AjoutVoiture(Voiture voiture)
        {
            return GestionGarage.AjoutVoiture(voiture);
        }
        public List<Voiture> GetVoitures()
        {
            return GestionGarage.GetVoitures();
        }

        public bool ModifVoiture(Voiture voiture)
        {
            return GestionGarage.ModifVoiture(voiture);
        }

        public List<Voiture> RechercheParCritere(string critere)
        {
            return GestionGarage.RechercheParCritere(critere);
        }

        public bool SuppVoitureById(int id)
        {
            return GestionGarage.SuppVoitureById(id);
        }
    }
}
