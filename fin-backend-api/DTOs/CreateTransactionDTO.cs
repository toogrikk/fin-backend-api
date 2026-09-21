using fin_backend_api.Models;

namespace fin_backend_api.DTOs
{
    public class CreateTransactionDTO
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
    }
}
