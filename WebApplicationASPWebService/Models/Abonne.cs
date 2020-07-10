using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationASPWebService.Models
{
    public class Abonne
    {
        //Utilisation des annotations pour valider le ModelState
        [Key]
        public int Numero { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Prenom { get; set; }
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@"^\w")]
        public string Mail { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
    }
}