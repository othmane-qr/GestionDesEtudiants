using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Models.Repositories
{
    public class EtudiantDbRepository : IEtudiantRepository<Etudiant>

    {
        EtudiantDbcontext db;
        public EtudiantDbRepository( EtudiantDbcontext _db)
        {
            db = _db;
        }
        public void Add(Etudiant entity)
        {
            db.Etudiants.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var etudiant = Find(id);
            db.Etudiants.Remove(etudiant);
            db.SaveChanges();
        }

        public Etudiant Find(int id)
        {
            var etudiant = db.Etudiants.SingleOrDefault(b => b.Id == id);
            return etudiant;
        }

        public IList<Etudiant> List()
        {
            return db.Etudiants.ToList();
        }

        public void Update(int id, Etudiant newEtudiant)
        {
            db.Update(newEtudiant);
            db.SaveChanges();

        }
        
        public List<Etudiant> Search (String term)
        {
            var result = db.Etudiants.Where(b => b.Nom.Contains(term) || b.Prenom.Contains(term) || b.CIN.Contains(term)).ToList();
            return result;


        }
    }
}