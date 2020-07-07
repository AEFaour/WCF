using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using WcfWServiceAbonnes.Model;

namespace WcfWServiceAbonnes.ViewModel_Traitement
{
    public class GestionAbonnes : IDisposable
    {
        private static EFAbonnes dtc = new EFAbonnes();
        public static int AjoutAbonne(Abonne abonne)
        {
            dtc.Abonnes.Add(abonne);
            return dtc.SaveChanges();
        }

        public static List<Abonne> ListAbonnes()
        {
            return dtc.Abonnes.ToList();
        }

        public static bool ModifAbonne(Abonne abonne)
        {
            // Abonne abonneModifie = abonne;
            //Syntaxe LINQ
            var _result = from a in dtc.Abonnes where a.Numero == abonne.Numero select a;
            if (_result == null)
            {
                return false;
            }
            //Syntaxe Fonctionnelle
            Abonne AbonneAmodifie1 = dtc.Abonnes.Where(x => x.Numero.Equals(abonne.Numero)).SingleOrDefault();
            Abonne AbonneAmodifie = _result.SingleOrDefault(); // Pour récupérer le seul élement de la liste

            AbonneAmodifie.Nom = abonne.Nom;
            AbonneAmodifie.Prenom = abonne.Prenom;
            AbonneAmodifie.Mail = abonne.Mail;

            int i = dtc.SaveChanges();
            return (i > 0);
        }

        public static List<Abonne> RechercheParCritere(string critere)
        {
            critere = critere.Trim().ToLower();
            // Chercher le critere : le nom, le prenom, le mail --
            var _result = from a in dtc.Abonnes
                          where (a.Nom.ToUpper().Contains(critere) || a.Prenom.ToUpper().Contains(critere) || a.Mail.ToUpper().Contains(critere))
                          select a;

            return _result.ToList();
        }

        public static bool SuppAbonneById(int id)
        {
            Abonne AbonneASuprimer = dtc.Abonnes.Where(x => x.Numero.Equals(id)).FirstOrDefault();
            if (AbonneASuprimer == null) return false;

            dtc.Abonnes.Remove(AbonneASuprimer);
            int _ret = dtc.SaveChanges();
            return (_ret > 0);
        }

        public void Dispose()
        {
            dtc.Dispose();
        }
    }
}