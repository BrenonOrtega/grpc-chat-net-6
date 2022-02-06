using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Chat.Models.Shared;

namespace Grpc.Chat.Models
{
    public class Chat : AuditableEntity<string>
    {
        IEnumerable<Message> Messages { get; set; } = new LinkedList<Message>();
    }
}