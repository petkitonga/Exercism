using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> baseValues, int max)
    {
        var valueTuples = baseValues
            .Where(x=>x>0)
            .Select(x => (value: x, multiplier: Math.Floor((double)max / x)));
        var sets = valueTuples
            .Select(x => Enumerable.Range(1, (int)x.multiplier).Select(e => x.value * e));
        var multiples = new List<int>();
        foreach (var set in sets)
        {
            multiples.AddRange(set);
        }

        return multiples.Where(x=>x!=max).Distinct().Sum();
    }
}