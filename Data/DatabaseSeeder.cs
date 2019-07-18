using System;
using System.Collections.Generic;
using System.Linq;
using PaymentsAPI.Models;

namespace PaymentsAPI.Data
{
    public class DatabaseSeeder
    {
        public static void InsertSeedData(PaymentsAPIContext context)
        {
            if (!context.Transactions.Any())
            {
                var transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        TransactionNumber = "3e43er5432",
                        CreationDate = new DateTime(2019, 2, 15),
                        CreditCard = "f3934hgf39q98hnrihfqhh82rh2f9ueh98hh4fu9f",
                        TransactionStatus = 1,
                        Transactiontype = 1,
                        LastFour = 4321
                    }
                };

                context.Transactions.AddRange(transactions);
                context.SaveChanges();
            }
        }
    }
}