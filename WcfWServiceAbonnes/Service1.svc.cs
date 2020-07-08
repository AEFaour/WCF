using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using WcfWServiceAbonnes.Model;
using WcfWServiceAbonnes.ViewModel_Traitement;

namespace WcfWServiceAbonnes
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public int AjoutAbonne(Abonne abonne)
        {
            return GestionAbonnes.AjoutAbonne(abonne);
        }

        public int AjoutAbonneJson(Abonne abonne)
        {
            return GestionAbonnes.AjoutAbonne(abonne);
        }

        public List<Abonne> ListAbonnes()
        {
            return GestionAbonnes.ListAbonnes();
        }

        public List<Abonne> ListeAbonnesJson()
        {
            return GestionAbonnes.ListAbonnes();
        }

        public Rss20FeedFormatter ListeAbonnesRSS()
        {
            return GestionAbonnes.ListeAbonnesRSS();
        }

        public List<Abonne> ListeAbonnesXML()
        {
            return GestionAbonnes.ListAbonnes();
        }

        public bool ModifAbonne(Abonne abonne)
        {
            return GestionAbonnes.ModifAbonne(abonne);
        }

        public bool ModifAbonneJson(Abonne abonne)
        {
            return GestionAbonnes.ModifAbonne(abonne);
        }

        public List<Abonne> RechercheParCritere(string critere)
        {
            return GestionAbonnes.RechercheParCritere(critere);
        }

        public bool SuppAbonneById(int id)
        {
            return GestionAbonnes.SuppAbonneById(id);
        }
    }
}
