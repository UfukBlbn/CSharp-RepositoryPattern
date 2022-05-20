using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
         TEntity GetById (int id);
        

        void Create(TEntity entity);
        

        void Update(TEntity entity);
        

        void Delete(int id);
     
    }
}