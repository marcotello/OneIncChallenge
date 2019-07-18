using System;

namespace PaymentsAPI.ViewModels
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreditCard { get; set; }
        public int TransactionStatus { get; set; }
        public int Transactiontype { get; set; }
        public int LastFour { get; set; }
    }
}