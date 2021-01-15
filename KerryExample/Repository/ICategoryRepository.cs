using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;

namespace KerryExample.Repository
{
    public interface ICategoryRepository
    {
        public Task<IEnumerable<Catgory>> GetAllCates();
        public Task<Catgory> GetCateById(string cateId);
        public void AddCate(Catgory catgory);
        public void DeleteCate(string cateId);
        public void UpdateCate(Catgory catgory);
        public bool IsCatExists(string cateId);
    }
}