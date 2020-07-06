using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceMonPremierApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        //public string GetData(int value)
        //{
        //    return string.Format("le carré du nombre est : {0}", value * value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public decimal Division(int a, int b)
        {
            return a / b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }
    }
}
