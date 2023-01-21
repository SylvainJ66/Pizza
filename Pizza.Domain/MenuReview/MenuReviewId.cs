using Pizza.Domain.Common;

namespace Pizza.Domain.MenuReview;

public sealed class MenuReviewId : ValueObject
{
    public Guid Value { get; }

    private MenuReviewId(Guid value)
    {
        Value = value;
    }

    public static MenuReviewId CreateUnique()
        => new(Guid.NewGuid());
    
    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }
}