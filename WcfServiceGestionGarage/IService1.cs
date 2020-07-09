using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceGestionGarage.Model;

namespace WcfServiceGestionGarage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int AjoutVoitre(Voiture voiture);
        [OperationContract]
        bool SuppVoitureById(int id);
        [OperationContract]
        bool ModifVoiture(Voiture voiture);
        [OperationContract]
        List<Voiture> ListVoitures();
        [OperationContract]
        List<Voiture> RechercheParCritere(string critere);
        // API - REST : Liste des voitures format Json
        [WebGet(UriTemplate = "/ListeJson/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Voiture> ListVoituresJson();
        // Pour indiquer qu'on va utiliser des acces Web pour récupérer les listes
        // Il faut modifier les comportements -behaviers - au niveau du fichier WebConfig 
        // Api - Rest : Liste des voitures au format XML
        // C'est le format par defaut --> pas besoin de spécifier le paraméter ResponseFormat
        [WebGet(UriTemplate = "/ListeXml/")]
        [OperationContract]
        List<Voiture> ListVoituresXML();
        // API - REST : Liste des voitures format RSS
        // Utiliser la classe Syndication du ServiceModel -> qui transforme la liste en RSS

        [WebGet(UriTemplate = "/ListeRss/")]
        [OperationContract]
        Rss20FeedFormatter ListeVoituresRSS();

        //API REST pour ajouter une voiture
        // Abonne est un objet : type complexe ne peut pas passer par Get(via l'URL), on utilise WebInvoke qui permet de faire
        // un Post
        // le POST permet de l'envoyer la voituree dans le body
        [WebInvoke(UriTemplate = "/AjoutVoiture/", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        int AjoutVoitureJson(Voiture voiture);
        // Api REST pour modifier une voiture
        [WebInvoke(UriTemplate = "/ModifVoiture/", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool ModifVoitureJson(Voiture voiture);

        // Api REST pour rechercher par critere
        //le critere est un sting --> type primitif alors on peut l'envoyer par GET
        [WebGet(UriTemplate = "/Recherche/{critere}/Voitures/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Voiture> RechercheVoitureParCriterJson(string critere);

        // Api REST pour rechercher une voiture par ID
        [WebGet(UriTemplate = "/RechercheVoiture/{id}/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]

        Voiture RechercherVoitureParIdJson(string id);
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
