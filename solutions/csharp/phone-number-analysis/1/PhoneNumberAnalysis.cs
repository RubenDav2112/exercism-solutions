public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var part1 = phoneNumber.Substring(0,3);
        var part2 = phoneNumber.Substring(4,3);
        var part3 = phoneNumber.Substring(8,4);

        return(part1 == "212", part2 == "555", part3);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
