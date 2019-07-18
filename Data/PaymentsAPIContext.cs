using Microsoft.EntityFrameworkCore;
using PaymentsAPI.Models;

namespace PaymentsAPI.Data
{
    public class PaymentsAPIContext : DbContext
    {
        public PaymentsAPIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}