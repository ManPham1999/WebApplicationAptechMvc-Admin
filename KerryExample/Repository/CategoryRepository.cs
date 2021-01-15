using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace KerryExample.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private MainDbContext _context;

        public CategoryRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Catgory>> GetAllCates()
        {
            return await _context.Catgories.ToListAsync();
        }

        public async Task<Catgory> GetCateById(string cateId)
        {
            return  await _context.Catgories.FindAsync(cateId);
        }


        public void AddCate(Catgory catgory)
        {
            throw new System.NotImplementedException();
        }

        public async void DeleteCate(string cateId)
        {
            var chosenCate = await GetCateById(cateId);
            chosenCate.Status = false;
        }

        public void UpdateCate(Catgory catgory)
        {
            _context.Catgories.Update(catgory);
        }

        public bool IsCatExists(string cateId)
        {
            return _context.Products.Any(e => e.Catgory.CatId == cateId);
        }
    }
}