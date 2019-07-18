using System.Collections.Generic;

namespace PaymentsAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        List<Transaction> Transactions { get; set; }
    }
}