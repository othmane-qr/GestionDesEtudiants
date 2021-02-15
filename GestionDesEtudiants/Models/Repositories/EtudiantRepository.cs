using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Models.Repositories
{
    public class EtudiantRepository : IEtudiantRepository<Etudiant>

    {
        List<Etudiant> etudiants;
        public EtudiantRepository()
        {
            etudiants = new List<Etudiant>()
            {
                new Etudiant
                {
                    Id = 1 , Nom = "Othmane" , Prenom = "Qorq" , CIN = "HA1111", Adresse ="Qu laghdir N00 youssoufia"
                },
                 new Etudiant
                {
                    Id = 2 , Nom = "Ossama" , Prenom = "Elh" , CIN = "HA22222", Adresse ="Qu laghdir N111 youssoufia"
                }

            };
        }
        public void Add(Etudiant entity)
        {
            etudiants.Add(entity);
        }

        public void Delete(int id)
        {
            var etudiant = Find(id);
            etudiants.Remove(etudiant);
        }

        public Etudiant Find(int id)
        {
            var etudiant = etudiants.SingleOrDefault(b => b.Id == id);
            return etudiant;
        }

        public IList<Etudiant> List()
        {
            return etudiants;
        }

        public void Update(int id, Etudiant newEtudiant)
        {
            var etudiant = Find(id);
            etudiant.Nom = newEtudiant.Nom;
            etudiant.Prenom = newEtudiant.Prenom;
            etudiant.CIN = newEtudiant.CIN;
            etudiant.Adresse = newEtudiant.Adresse;


        }
    }
}
