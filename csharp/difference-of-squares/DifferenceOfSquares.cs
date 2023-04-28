using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = Enumerable.Range(1, max).Sum();
        return sum*sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
       return Enumerable.Range(1, max).Select(x => x*x).Sum();
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return Math.Abs(CalculateSquareOfSum(max)-CalculateSumOfSquares(max));
    }
}