using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceGarage.Model;

namespace WcfServiceGarage
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWSGarage" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWSGarage
    {
        // SOAP
        [OperationContract]
        int AjoutVoiture(Voiture voiture);
        [OperationContract]
        bool ModifVoiture(Voiture voiture);
        [OperationContract]
        bool SuppVoitureById(int id);
        [OperationContract]
        List<Voiture> GetVoitures();
        [OperationContract]
        List<Voiture> RechercheParCritere(string critere);

        // Rest ...
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
