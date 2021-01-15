using System.Threading.Tasks;
using KerryExample.Entity;
using KerryExample.Repository;
using Microsoft.AspNetCore.Mvc;

namespace KerryExample.Controllers
{
    public class HistoryController : Controller
    {
        private readonly TransactionRepository _repository;
        public HistoryController(MainDbContext context)
        {
            _repository = new TransactionRepository(context);
        }

        public async Task<IActionResult> Index()
        {
            ModelView modelView = new ModelView();
            modelView.transactions = await _repository.GetAllTransactions();
            return View(modelView);
        }
    }
}