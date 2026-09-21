namespace fin_backend_api.Models
{
    public class Account
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string AccountName { get; private  set; }

        public Account(int userId, string accountName)
        {
            UserId = userId;
            AccountName = accountName;
        }

        private Account() { } // For EF Core
    }
}
