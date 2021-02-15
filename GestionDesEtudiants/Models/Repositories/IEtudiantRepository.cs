﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDesEtudiants.Models.Repositories
{
   public interface IEtudiantRepository<TEntity>
    {
        IList<TEntity> List();

        TEntity Find(int id);

        void Add(TEntity entity);

        void Update(int id, TEntity entity);

        void Delete(int id);

    }
}
