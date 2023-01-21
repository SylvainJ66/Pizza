using Pizza.Domain.Common;

namespace Pizza.Domain.Host.ValueObjects;

public sealed class HostId : ValueObject
{
    public Guid Value { get; }

    public HostId(Guid value)
    {
        Value = value;
    }

    public static HostId CreateUnique()
        => new(Guid.NewGuid());
    
    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }
}