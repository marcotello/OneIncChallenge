using System.Collections.Generic;
using System.Threading.Tasks;
using PaymentsAPI.Data;
using PaymentsAPI.Models;

namespace PaymentsAPI.Repositories
{
    public class TransactionRepository: Repository<Transaction>, ITransactionRespository
    {
        private PaymentsAPIContext _appContext => (PaymentsAPIContext) _context;

        // Constructor
        public TransactionRepository(PaymentsAPIContext context) : base(context)
        { 
            
        }

        public Task<List<Transaction>> GetTransactionByUserId(int userId)
        {
            return null;
        }
    }
}