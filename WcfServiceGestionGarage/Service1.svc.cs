using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceGestionGarage.Model;
using WcfServiceGestionGarage.ViewModel;

namespace WcfServiceGestionGarage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public int AjoutVoitre(Voiture voiture)
        {
            return GestionGarage.AjoutVoiture(voiture);
        }

        public List<Voiture> ListVoitures()
        {
            return GestionGarage.ListVoitures();
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
