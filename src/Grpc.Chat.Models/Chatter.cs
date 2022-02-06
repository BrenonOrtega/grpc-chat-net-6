using Grpc.Chat.Models.Shared;

namespace Grpc.Chat.Models;
public class Chatter : Entity<string>
{
    public override string Id { get; init; } = Guid.NewGuid().ToString();
    public string NickName { get; init; } = string.Empty;
    public User User { get; set; } = User.Empty;
    public IEnumerable<Message> Messages { get; init; } = new LinkedList<Message>();
}
