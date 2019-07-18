using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PaymentsAPI.Repositories;
using PaymentsAPI.ViewModels;

namespace PaymentsAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRespository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRespository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<List<TransactionViewModel>> GetTransactionsByUserIdAsync(int userId)
        {
            var transactions = await _transactionRepository.GetAllAsync();
            return _mapper.Map<List<TransactionViewModel>>(transactions);
        }

        public async Task<List<TransactionViewModel>> GetTransactions()
        {
            var transactions = await _transactionRepository.GetAllAsync();
            return _mapper.Map<List<TransactionViewModel>>(transactions);
        }
    }
}