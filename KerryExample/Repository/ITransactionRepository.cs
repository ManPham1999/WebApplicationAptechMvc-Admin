using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KerryExample.Entity;

namespace KerryExample.Repository
{
    public interface ITransactionRepository
    {
        public Task<IEnumerable<Cart>> GetAllTransactions();
        public Task<List<CartLine>> GetAllTransactionsPr(Guid guid);
    }
}