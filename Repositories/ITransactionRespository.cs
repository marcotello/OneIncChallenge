using System.Collections.Generic;
using System.Threading.Tasks;
using PaymentsAPI.Models;

namespace PaymentsAPI.Repositories
{
    public interface ITransactionRespository : IRepository<Transaction>
    {
        Task<List<Transaction>> GetTransactionByUserId(int userId);
    }
}