using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>

            balance switch
            {
                _ when balance < 0 => 3.213f,
                _ when balance >= 0 && balance < 1000 => 0.5f,
                _ when balance >= 1000 && balance < 5000 => 1.621f,
                _ when balance >= 5000 => 2.475f,
                _ => throw new ArgumentOutOfRangeException(nameof(balance))
                
            };



    public static decimal Interest(decimal balance) => balance * (decimal) InterestRate(balance) / 100;


    public static decimal AnnualBalanceUpdate(decimal balance) => (balance + Interest(balance));


    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        if (balance < 0) throw new ArgumentOutOfRangeException($"balance is negative{nameof(balance)}");
        if (balance >= targetBalance) return 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
