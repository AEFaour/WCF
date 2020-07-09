using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WpfAppMeteoClient.Model;
using WpfAppMeteoClient.ServiceReference1;

namespace WpfAppMeteoClient.Helper
{
    class AccesWS
    {
        public static ResultatMeteo GetInfoMeteo(int typeInfo)
        {
            Service1Client client = new Service1Client();

            string _date, _desc, _res;
            _res = client.Get_Value(typeInfo, out _date, out _desc);
            client.Close();
            // Retourner ces 3 infos sous forme d'objet

            ResultatMeteo resultatMeteo = new ResultatMeteo();
            resultatMeteo.Datereleve = _date;
            resultatMeteo.DescriptifReleve = _desc;
            resultatMeteo.ValeurReleve = _res;
            return resultatMeteo;
        }
    }
}
