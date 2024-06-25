using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try 
        {
            string denomination = checked($"{@base * multiplier}");
            return denomination;
        } catch (OverflowException e)
        {
            return "*** Too Big ***";
        }
    }


    public static string DisplayGDP(float @base, float multiplier)
    {
        float gdp = checked(@base * multiplier);
        if (gdp == float.PositiveInfinity)
        {
            return "*** Too Big ***";
        }
        else return $"{gdp}";

    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            decimal salary = checked(salaryBase * multiplier);
            return $"{salary}";
        }
        catch (OverflowException e)
        {
            return "*** Much Too Big ***";
        }
        

    }
}
