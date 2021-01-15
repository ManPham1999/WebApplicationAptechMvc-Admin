using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KerryExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace KerryExample.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private MainDbContext _context;

        public TransactionRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cart>> GetAllTransactions()
        {
            return await _context.Carts.Include(c => c.CardType).Include(u => u.User).ToListAsync();
        }
    }
}