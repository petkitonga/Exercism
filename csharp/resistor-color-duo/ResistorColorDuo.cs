using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        colors = colors.Select(c => c.ToLower()).ToArray();
        var colorsList = (new string[] {
            "black", "brown", "red", "orange", "yellow",
            "green", "blue", "violet", "grey", "white"
        }).ToList();

        var indexArr = colors
            .Select(c=>colorsList.IndexOf(c))
            .Take(2)
            .ToArray();
            
        return Convert.ToInt32(string.Join(string.Empty, indexArr) );

    }
}
