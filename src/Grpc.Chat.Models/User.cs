using Grpc.Chat.Models.Shared;

namespace Grpc.Chat.Models
{
    public class User : AuditableEntity<string>
    {
        internal static readonly User Empty = new();

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        private User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string Email { get; } = string.Empty;

    }
}