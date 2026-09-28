namespace fin_backend_api.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Email { get; private set; }
        public bool AdminRights { get; private set; }

        public User(string first_name, string second_name, string email, bool admin_rings)
        {
            FirstName = first_name;
            SecondName = second_name;
            Email = email;
            AdminRights = admin_rings;
        }

        private User() { } // For EF Core
    }
}
