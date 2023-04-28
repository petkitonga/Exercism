using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string inputStr, string delimiter)
    {
        var pos = inputStr.IndexOf(delimiter)+delimiter.Length;
        return inputStr.Substring(pos, inputStr.Length - pos);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string inputStr, string start, string end)
    {
        var pos1 = inputStr.IndexOf(start)+start.Length;
        var pos2 = inputStr.IndexOf(end);
        return inputStr.Substring(pos1, pos2 - pos1);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]");
    }
}