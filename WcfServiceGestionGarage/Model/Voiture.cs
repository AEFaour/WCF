using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WcfServiceGestionGarage.Model
{
    public class Voiture
    {
        [Key]

        public int Numero { get; set; }
        public string Matricule { get; set; }
        public int NumeroChassis { get; set; }
        public string Marque { get; set; }
        public string Nom { get; set; }
        public string Photo { get; set; }

    }
}