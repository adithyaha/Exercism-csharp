using System;
using System.Linq;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var tupleList = phoneNumber.Split('-');

        if (tupleList.Length != 3)
        {
            throw new ArgumentException("Invalid phone number format.");
        }

        bool isFake = tupleList[1] == "555";
        bool isNewYork = tupleList[0] == "212";
        string localNumber = tupleList[2];

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.Item2;
    }
}
