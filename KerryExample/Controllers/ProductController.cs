using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KerryExample;
using KerryExample.Entity;

namespace KerryExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly MainDbContext _context;

        public ProductController(MainDbContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            ModelView modelView = new ModelView();
            modelView.products = await _context.Products.Include(c => c.Catgory).ToListAsync();
            return View(modelView);
        }

        // GET: User/Create
        public async Task<IActionResult> Create()
        {
            ModelView modelView = new ModelView();
            modelView.catgories = await _context.Catgories.ToListAsync();
            return View(modelView);
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Status,Price,Quantity,Img,Desc,CatgoryRefId")]
            Product product)
        {
            ModelView modelView = new ModelView();
            if (ModelState.IsValid)
            {
                var chosenCate = await _context.Catgories.FindAsync(product.CatgoryRefId);
                var newPro = new Product
                {
                    Name = product.Name, Price = product.Price, Status= product.Status,Quantity= product.Quantity,Img= product.Img,Desc = product.Desc, Catgory = chosenCate
                };
                _context.Products.Add(newPro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(modelView);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModelView modelView = new ModelView();
            modelView.product = await _context.Products.FindAsync(id);
            modelView.catgories = await _context.Catgories.ToListAsync();
            if (modelView.product == null)
            {
                return NotFound();
            }

            return View(modelView);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Status,Price,Quantity,Img,Desc,CatgoryRefId")]
            Product product)
        {
            ModelView modelView = new ModelView();
            modelView.product = product;
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var chosenCate = await _context.Catgories.FindAsync(product.CatgoryRefId);
                    product.Catgory = chosenCate;
                    _context.Products.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModelView modelView = new ModelView();
            var pro = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            modelView.product = pro;
            if (pro == null)
            {
                return NotFound();
            }

            return View(modelView);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pro = await _context.Products.FindAsync(id);
            pro.Status = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}