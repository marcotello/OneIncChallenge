using System.Collections.Generic;
using System.Threading.Tasks;
using PaymentsAPI.ViewModels;

namespace PaymentsAPI.Services
{
    public interface ITransactionService
    {
         Task<List<TransactionViewModel>> GetTransactionsByUserIdAsync(int userId);
    }
}