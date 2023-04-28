using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var pos = logLine.IndexOf(":")+1;
        var message = logLine.Substring(pos, logLine.Length - pos);
        return message.Trim();

    }

    public static string LogLevel(string logLine)
    {
        var pos = logLine.IndexOf(":");
        var level = logLine.Substring(0, pos).Replace("[", string.Empty)
            .Replace("]", string.Empty)
            .Replace(":", string.Empty)
            .ToLower();
        return level;
    }

    public static string Reformat(string logLine)
    {
        var reformattedLine = $"{Message(logLine)} ({LogLevel(logLine)})";
        return reformattedLine;
    }
}
