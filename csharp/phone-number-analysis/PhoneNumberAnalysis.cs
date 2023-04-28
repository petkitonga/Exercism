using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        return (IsNewYork: phoneNumber.Substring(0, 3).Equals("212"),
            IsFake: phoneNumber.Substring(4, 3).Equals("555"),
            LocalNumber: phoneNumber.Substring(8, 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
