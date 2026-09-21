namespace fin_backend_api.Models
{
    public class Transaction
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType Type { get; private set; }
        public int AccountId { get; private set; }
        public int CategoryId { get; private set; }

        public Transaction(DateTime date, decimal amount, TransactionType type, int accountId, int categoryId)
        {
            Date = date;
            Amount = amount;
            Type = type;
            AccountId = accountId;
            CategoryId = categoryId;
        }

        private Transaction() { } // For EF Core   
    }
}
