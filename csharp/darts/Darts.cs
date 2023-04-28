using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        var lengthFromCenter = Math.Sqrt((x*x)+(y*y)) ;
        var score = lengthFromCenter <= 1 ? 10
            : lengthFromCenter <= 5 ? 5
            : lengthFromCenter <= 10 ? 1
            : 0;
        return score;
    }
}
