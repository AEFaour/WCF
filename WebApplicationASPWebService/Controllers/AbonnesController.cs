using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationASPWebService.Models;

namespace WebApplicationASPWebService.Controllers
{
    public class AbonnesController : ApiController, IDisposable
    {
        private EFAbonneDbContext _DbContext = new EFAbonneDbContext(); // DbContext
        //Retourner une liste json des abonnés en base
        // GET api/abonnes
        /// <summary>
        /// WEB API pour récupérer la liste des abonnnes 
        /// au format JSON
        /// 
        /// </summary>
        /// <returns>liste abonnés</returns>
        public IEnumerable<Abonne> GetAbonnes()
        {
            return _DbContext.Abonnes.ToList();
        }

        // rechercher un abonné par son id
        // GET api/abonnes/5

        /// <summary>
        /// Chercher un abonné par ID
        /// </summary>
        /// <param name="id">Abonne cherché ou HTTP not found</param>
        /// <returns></returns>

        public Abonne GetAbonne(int id)
        {
            Abonne abonne = _DbContext.Abonnes.SingleOrDefault(x => x.Numero == id);
            if (abonne == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return abonne;
        }

        // Ajouter Abonne (envoyer en Json dans le body)
        // POST api/abonnes
        [HttpPost]
        public Abonne AjoutAbonne(Abonne abonne)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _DbContext.Abonnes.Add(abonne);

            if (_DbContext.SaveChanges() > 0) return abonne;
            else
                throw new HttpResponseException(HttpStatusCode.BadRequest);
        }

        // Modifier un abonne
        // PUT api/abonnes/5
        [HttpPut]
        public void ModifAbonnes(Abonne abonne)
        {
            Abonne abonneAModifier = _DbContext.Abonnes.SingleOrDefault(x => x.Numero == abonne.Numero);
            if (abonneAModifier == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            // Pour affecter un objet du Models dans un autre récupéré depuis la base: on utilise Automapper ...
            abonneAModifier.Mail = abonne.Mail; abonneAModifier.Prenom = abonne.Prenom; abonneAModifier.Telephone = abonne.Telephone;

            _DbContext.SaveChanges();
        }

        //Supprimer
        // DELETE api/abonnes/5
        [HttpDelete]
        public void SupprimerAbonne(int id)
        {
            Abonne abonneASupp = _DbContext.Abonnes.SingleOrDefault(x => x.Numero == id);
            if (abonneASupp == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _DbContext.Abonnes.Remove(abonneASupp);
            _DbContext.SaveChanges();
        }
    }
}
