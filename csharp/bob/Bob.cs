using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        bool hasLetters = statement.Any(c=>char.IsLetter(c));
        bool isQuestion = statement.IndexOf("?") == statement.Length - 1;
        bool isYelling = statement.Equals(statement.ToUpper()) && hasLetters;

        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        else if (isQuestion)
            return isYelling ? "Calm down, I know what I'm doing!" : "Sure.";
        else if (isYelling)
            return "Whoa, chill out!";
        return "Whatever.";
    }
}