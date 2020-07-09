using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceGarage.Model;

namespace WcfServiceGarage.ViewModel
{
    public class GestionGarage : IDisposable
    {
        private static EFGarage dtc = new EFGarage();
        public static int AjoutVoiture(Voiture voiture)
        {
            dtc.Voitures.Add(voiture);

            return dtc.SaveChanges();
        }

        public void Dispose()
        {
            dtc.Dispose(); ;
        }

        public static List<Voiture> GetVoitures()
        {
            return dtc.Voitures.ToList();
        }

        public static bool ModifVoiture(Voiture voiture)
        {
            Voiture AModifier = dtc.Voitures.Where(x => x.Numero.Equals(voiture.Numero)).SingleOrDefault();
            AModifier.Marque = voiture.Marque; AModifier.Matricule = voiture.Matricule;
            AModifier.Nom = voiture.Nom; AModifier.Photo = AModifier.Photo;
            return (dtc.SaveChanges() > 0);
        }

        public static List<Voiture> RechercheParCritere(string critere)
        {
            critere = critere.ToLower();

            var res = from v in dtc.Voitures
                      where v.Marque.ToLower().Contains(critere)
                        || v.Nom.ToLower().Contains(critere)
                        || v.Matricule.ToLower().Contains(critere)
                        || v.Photo.ToLower().Contains(critere)
                       || v.Chassis.ToString().ToLower().Contains(critere)
                      select v;
            return res.ToList();
        }

        public static bool SuppVoitureById(int id)
        {
            Voiture v = (from x in dtc.Voitures
                         where x.Numero == id
                         select x).SingleOrDefault();
            if (v != null)
            {
                dtc.Voitures.Remove(v);
                return (dtc.SaveChanges() > 0);
            }
            else return false;
        }
    }
}