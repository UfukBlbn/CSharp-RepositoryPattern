using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Entity;

namespace RepositoryPattern.DataAccess.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category[] GetCategories();
    }
}