using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWebServiceMeteo.Model
{
    // classe entité : on a juste besoin des proprétés
    public class Meteo
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
    }
}
