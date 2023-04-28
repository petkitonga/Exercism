using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed>=1&& speed<=4)
        {
            return 1;
        }else if (speed>=5&& speed <= 8)
        {
            return 0.9;
        }
        else
        {
            return speed == 0 ? 0 : speed == 9 ? 0.8 : 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * speed * 221;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}
