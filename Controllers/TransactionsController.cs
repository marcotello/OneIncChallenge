using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Services;
using PaymentsAPI.ViewModels;

namespace PaymentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        
        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        
        // GET: api/Transactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TransactionViewModel>>> GetTransactionsById(int UserId)
        {
            return Ok("working");
        }
    }
}