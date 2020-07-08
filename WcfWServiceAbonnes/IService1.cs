using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using WcfWServiceAbonnes.Model;

namespace WcfWServiceAbonnes
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int AjoutAbonne(Abonne abonne);
        [OperationContract]
        bool SuppAbonneById(int id);
        [OperationContract]
        bool ModifAbonne(Abonne abonne);
        [OperationContract]
        List<Abonne> ListAbonnes();
        [OperationContract]
        List<Abonne> RechercheParCritere(string critere);

        // API - REST : Liste des abonnés format Json
        [WebGet(UriTemplate = "/ListeJson/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Abonne> ListeAbonnesJson();
        // Pour indiquer qu'on va utiliser des acces Web pour récupérer les listes
        // Il faut modifier les comportements -behaviers - au niveau du fichier WebConfig 
        // Api - Rest : Liste des abonnés au format XML
        // C'est le format par defaut --> pas besoin de spécifier le paraméter ResponseFormat
        [WebGet(UriTemplate = "/ListeXml/")]
        [OperationContract]
        List<Abonne> ListeAbonnesXML();
        // API - REST : Liste des abonnés format RSS
        // Utiliser la classe Syndication du ServiceModel -> qui transforme la liste en RSS

        [WebGet(UriTemplate = "/ListeRss/")]
        [OperationContract]
        Rss20FeedFormatter ListeAbonnesRSS();
        //API REST pour ajouter un abonné
        // Abonne est un objet : type complexe ne peut pas passer par Get(via l'URL), on utilise WebInvoke qui permet de faire
        // un Post
        // le POST permet de l'envoyer le'abonne dans le body
        [WebInvoke(UriTemplate = "/AjoutAbonne/", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        int AjoutAbonneJson(Abonne abonne);

        // Api REST pour modifier un abonné
        [WebInvoke(UriTemplate = "/ModifAbonne/", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool ModifAbonneJson(Abonne abonne);
        // Api REST pour rechercher par critere
        //le critere est un sting --> type primitif alors on peut l'envoyer par GET
        [WebGet(UriTemplate = "/Recherche/{critere}/Abonnes/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Abonne> RechercheParCriterJson(string critere);

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
