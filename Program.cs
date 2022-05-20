using System;
using ConsoleApp.DataAccess.Concrete;
using RepositoryPattern.DataAccess.Abstract;
using RepositoryPattern.Entity;

namespace RepositoryPattern
{

    class ProductManager : IProductRepository
    {
        
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var productDal = new EfProductDal();
            // productDal.Create(new Product());

            var productDal = new ProductManager(new EfProductDal());
            productDal.Create(new Product());
        }
    }
}
