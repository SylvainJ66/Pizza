namespace Pizza.Domain.Common;

public class AggregateRoot<TId> : Entity<TId>, IAggregateRoot
    where TId : notnull
{
    public AggregateRoot(TId id) : base(id)
    {
        
    }
}

public interface IAggregateRoot 
{
}