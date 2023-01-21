namespace Pizza.Domain.Common;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetEqualityComponent();

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
            return false;
        var valueObject = (ValueObject)obj;
        return GetEqualityComponent()
            .SequenceEqual(valueObject.GetEqualityComponent());
    }

    public static bool operator ==(ValueObject left, ValueObject right)
        => Equals(left, right);
    

    public static bool operator !=(ValueObject left, ValueObject right)
        => !Equals(left, right);

    public override int GetHashCode()
    {
        return GetEqualityComponent()
            .Select(v => v?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }
    
    public bool Equals(ValueObject? other) 
        => Equals((object?)other);
}


