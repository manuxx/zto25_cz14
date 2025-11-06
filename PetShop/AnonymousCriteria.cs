using System;

public class AnonymousCriteria<TItem>:Criteria<TItem>
{
    private readonly Predicate<TItem> _condition;

    public AnonymousCriteria(Predicate<TItem> condition)
    {
        _condition = condition;
    }

    public bool IsSatisfied(TItem item)
    {
        return _condition(item);
    }
}