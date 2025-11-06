using System;
using System.Collections.Generic;
using Training.DomainClasses;

public static class EnumerableExtensions
{
    public static IEnumerable<TItem> OneAtATime<TItem>(this IEnumerable<TItem> items)
    {
        foreach (var item in items)
        {
            yield return item;
        }
    }

    public static IEnumerable<Pet> AllThatSatisfy(this IList<Pet> pets, Func<Pet, bool> condition)
    {
        foreach (var pet in pets)
        {
            if (condition(pet))
                yield return pet;
        }
    }
}