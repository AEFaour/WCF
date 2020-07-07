﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServiceGestionGarage.Model;

namespace WcfServiceGestionGarage.ViewModel
{
    public class GestionGarage : IDisposable
    {
        private static EFVoitures dtc = new EFVoitures();
        public static int AjoutVoiture(Voiture voiture)
        {
            dtc.Voitures.Add(voiture);
            return dtc.SaveChanges();
        }

        public static List<Voiture> ListVoitures()
        {
            return dtc.Voitures.ToList();
        }

        public static bool ModifVoiture(Voiture voiture)
        {
            var _result = from v in dtc.Voitures where v.Numero == voiture.Numero select v;
            if (_result == null)
            {
                return false;
            }
            //Syntaxe Fonctionnelle
            Voiture VoitureAmodifie1 = dtc.Voitures.Where(x => x.Numero.Equals(voiture.Numero)).SingleOrDefault();
            Voiture VoitureAmodifie = _result.SingleOrDefault(); // Pour récupérer le seul élement de la liste

            VoitureAmodifie.Numero = voiture.Numero;
            VoitureAmodifie.Nom = voiture.Nom;
            VoitureAmodifie.NumeroChassis = voiture.NumeroChassis;
            VoitureAmodifie.Marque = voiture.Marque;
            VoitureAmodifie.Photo = voiture.Photo;

            int i = dtc.SaveChanges();
            return (i > 0);
        }

        public static List<Voiture> RechercheParCritere(string critere)
        {
            critere = critere.Trim().ToLower();

            var _result = from v in dtc.Voitures
                          where (v.Numero.ToString().Contains(critere) || v.Nom.ToUpper().Contains(critere) || v.NumeroChassis.ToString().Contains(critere) || v.Marque.ToUpper().Contains(critere) || v.Photo.ToUpper().Contains(critere))
                          select v;

            return _result.ToList();
        }

        public static bool SuppVoitureById(int id)
        {
            Voiture VoitureASuprimer = dtc.Voitures.Where(x => x.Numero.Equals(id)).FirstOrDefault();
            if (VoitureASuprimer == null) return false;

            dtc.Voitures.Remove(VoitureASuprimer);
            int _ret = dtc.SaveChanges();
            return (_ret > 0);
        }

        public void Dispose()
        {
            dtc.Dispose();
        }
    }
}