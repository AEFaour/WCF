using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppClientGarageWS.ServiceReference1;

namespace WpfAppClientGarageWS.HelperWS
{
    public class AccesWS
    {
        public static List<Voiture> GetVoituresFromWS()
        {
            List<Voiture> _list = new List<Voiture>();


            // le service peut etre down alors Try-Catch
            try
            {
                WSGarageClient client = new WSGarageClient();
                _list = client.GetVoitures().ToList();
                client.Close();
            }
            catch (Exception e)
            {
                // Retourne une Exception : Propager l'exception 
                //
                throw new Exception(" Erreur d'acces à la méthode GetVoiture du WS " + e.Message);

                // MessageBox.Show("Probleme de WS"); // On gère l'exception

            }

            return _list;
        }

        internal static int AjoutVoitureWS(Voiture voiture)
        {

            int ret = -1;
            try
            {
                WSGarageClient client = new WSGarageClient();
                ret = client.AjoutVoiture(voiture);
                client.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Echec - Ajout via le WS " + e.Message);
            }
            return ret;
        }
    }
}
