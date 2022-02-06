namespace Grpc.Chat.Models.Shared;
public interface IEntity<T>
{
    T Id { get; init; }
}

public interface IAuditableEntity<T> : IEntity<T>
{
    DateOnly CreationDate { get; set; }

    TimeOnly CreationTime { get; set; }
}

public abstract class Entity<T> : IEntity<T>
{
    public virtual T Id { get; init; }
}

public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity<T>
{
    public DateOnly CreationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public TimeOnly CreationTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
}