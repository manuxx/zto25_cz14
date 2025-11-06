using System;
using System.Collections.Generic;
using Training.DomainClasses;

public static class EE
{
    public static IEnumerable<Pet> AllThatSatisfy(IList<Pet> petsInTheStore, Func<Pet, bool> condition)
    {
        foreach (var pet in petsInTheStore)
        {
            if (condition(pet))
                yield return pet;
        }
    }
}