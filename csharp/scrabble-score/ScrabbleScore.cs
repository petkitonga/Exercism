using System;
using System.Collections.Generic;
using System.Linq;

using static System.Formats.Asn1.AsnWriter;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        (string letters, int score)[] scoreTuples = new(string letters, int score)[]
        { 
            ("A, E, I, O, U, L, N, R, S, T", 1), ("D, G",  2), ("B, C, M, P", 3),
            ("F, H, V, W, Y", 4), ("K",5), ("J, X", 8), ("Q, Z", 10)
        };

        var totalScore = input.ToCharArray().Select(x => 
        scoreTuples.Single(t=>t.letters.Contains(char.ToUpper(x))).score).Sum();

        return totalScore;

    }
}