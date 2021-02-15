using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Models
{
    public class EtudiantDbcontext : DbContext
    {
        public EtudiantDbcontext( DbContextOptions<EtudiantDbcontext>options ) :base (options)
        {
                
        }

        public  DbSet<Etudiant> Etudiants { get; set; }
    }
}
