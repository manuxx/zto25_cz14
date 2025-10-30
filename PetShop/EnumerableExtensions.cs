using System.Collections.Generic;
using Training.DomainClasses;

public static class EnumerableExtensions
{
    public static IEnumerable<Pet> OneAtATime(IEnumerable<Pet> items)
    {
        foreach (var pet in items)
        {
            yield return pet;
        }
    }
}