using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idStr = id == null ? string.Empty : $"[{id}] - ";
        department = (department ?? "OWNER").ToUpper();
        return $"{idStr}{name} - {department}";
    }
}
