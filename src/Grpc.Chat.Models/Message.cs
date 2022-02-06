using Grpc.Chat.Models.Shared;

namespace Grpc.Chat.Models
{
    public class Message : AuditableEntity<string>
    {
        public string SenderId { get; set; }
        public string Text { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public Chat Chat { get; set; }
    }
}