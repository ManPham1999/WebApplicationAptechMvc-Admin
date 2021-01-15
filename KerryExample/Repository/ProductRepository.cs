using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace KerryExample.Repository
{
    public class ProductRepository : IProductRepository
    {
        private MainDbContext _db ;

        public ProductRepository(MainDbContext db)
        {
            _db = db;
        }

        public void AddProduct(Product pro)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Guid proId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProductByCatgoryId(string catId)
        {
            IQueryable<Product> chosenPro =  _db.Products.Where(p => p.Catgory.CatId == catId);
            return chosenPro;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _db.Products.Include(c => c.Catgory).ToListAsync();
        }

        public async Task<Product> GetProductById(Guid proId)
        {
            var chosenPro = await _db.Products.FindAsync(proId);
            return chosenPro;
        }

        public void UpdateProduct(Guid proId)
        {
            throw new NotImplementedException();
        }

        public bool ProductExists(Guid proId)
        {
            return _db.Products.Any(e => e.Id == proId);
        }
    }
}