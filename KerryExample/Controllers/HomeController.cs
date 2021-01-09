using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KerryExample.Models;
using Microsoft.EntityFrameworkCore;

namespace KerryExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainDbContext _context;

        public HomeController(ILogger<HomeController> logger, MainDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ModelView mymodel = new ModelView();
            mymodel.products = await _context.Products.ToListAsync();
            mymodel.catgories = await _context.Catgories.ToListAsync();
            return View(mymodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
