using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppGestionGarageManagement.ServiceReference1;

namespace WpfAppGestionGarageManagement.HelperWS
{
    public class AccesWS
    {
        public static List<Voiture> GetVoituresFromWS()
        {
            List<Voiture> _list = new List<Voiture>();

            try
            {
                WSGarageClient client = new WSGarageClient();
                //_list = client.ListVoitures().ToList();
                _list = client.ListVoitures().ToList();
                client.Close();
            }
            catch (Exception e)
            {
                // Retourne une Exception : Propager l'exception
                throw new Exception("Erreur d'acces à la méthode ListeVoiture du W" + e.Message);
                // MessageBox.Show("Problème de WS"); //On gère l'excpetion

            }
            return _list;
        }

        internal static int ajoutVoiture(Voiture voiture)
        {
            int ret = -1;
            try
            {
                WSGarageClient client = new WSGarageClient();
                ret = client.AjoutVoitre(voiture);
                client.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Echec - Ajout ws ");
            }
            return ret;
        }
    }
}
