using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;

namespace KerryExample.Repository
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetAllProducts();
        public Task<Product> GetProductById(Guid proId);
        public IQueryable<Product> GetProductByCatgoryId(string catId);
        void AddProduct(Product pro);
        void DeleteProduct(Guid proId);
        void UpdateProduct(Guid proId);
        bool ProductExists(Guid proId);
    }
}