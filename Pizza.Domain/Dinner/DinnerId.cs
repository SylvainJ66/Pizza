using Pizza.Domain.Common;

namespace Pizza.Domain.Dinner;

public sealed class DinnerId : ValueObject
{
    public Guid Value { get; }

    public DinnerId(Guid value)
    {
        Value = value;
    }

    public static DinnerId CreateUnique()
        => new(Guid.NewGuid());
    
    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }
}