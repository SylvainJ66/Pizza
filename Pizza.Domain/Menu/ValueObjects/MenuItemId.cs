using Pizza.Domain.Common;

namespace Pizza.Domain.Menu.ValueObjects;

public sealed class MenuItemId : ValueObject
{
    public Guid Value { get; }

    private MenuItemId(Guid value)
    {
        Value = value;
    }

    public static MenuItemId CreateUnique()
        => new(Guid.NewGuid());
    
    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }
}