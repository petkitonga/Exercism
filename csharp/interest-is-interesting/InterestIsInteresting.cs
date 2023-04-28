using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    { 
        return balance<0? 3.213f:
            balance>=0 && balance< 1000? 0.5f:
            balance>=1000 && balance<5000? 1.621f
            : 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * ((decimal)InterestRate(balance) * 0.01m);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var totalBalance = AnnualBalanceUpdate(balance);
        var numYears = 1;
        do
        {
            totalBalance = AnnualBalanceUpdate(totalBalance);
            numYears++;
        } while(totalBalance <= targetBalance);

        return numYears;
    }
}
