using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KerryExample.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MainDbContext _context ;

        public CategoryController(MainDbContext context)
        {
            _context = context;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            ModelView mymodel = new ModelView();
            mymodel.catgories = await _context.Catgories.ToListAsync();
            return View(mymodel);
        }
    }
}