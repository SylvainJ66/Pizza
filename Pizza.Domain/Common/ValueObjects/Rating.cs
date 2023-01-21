namespace Pizza.Domain.Common.ValueObjects;

public class Rating : ValueObject
{
    public int Value { get; private set; }

    private Rating(int value)
    {
        Value = value;
    }

    public static Rating CreateNew(
        int value)
        => new(value);

    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }
}