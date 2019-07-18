using AutoMapper;
using PaymentsAPI.Models;
using PaymentsAPI.ViewModels;

namespace PaymentsAPI.Config
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Transaction, TransactionViewModel>().ReverseMap();
        }
    }
}