using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var charArr = (input.ToCharArray()).Reverse();
        return string.Join(string.Empty, charArr);
    }
}