using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModelView modelView = new ModelView();
            modelView.catgory = await _context.Catgories.FindAsync(id);
            modelView.catgories = await _context.Catgories.ToListAsync();
            if (modelView.catgory == null)
            {
                return NotFound();
            }
            return View(modelView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CatId,Name,Status")]Catgory catgory)
        {
            ModelView modelView = new ModelView();
            modelView.catgory = catgory;
            if (id != catgory.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Catgories.Update(catgory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IsCatExists(catgory.CatId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(modelView);
        }
        public bool IsCatExists(string id)
        {
            return _context.Products.Any(e => e.Catgory.CatId == id);
        }

        public async Task<IActionResult> Delete(string id)
        {
            ModelView modelView = new ModelView();
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Catgories.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            modelView.catgory = cat;
            return View(modelView);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Catgories.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }
            cat.Status = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}