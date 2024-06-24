using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch(speed)
        {
            case 0: return 0;
            case 1:
            case 2:
            case 3:
            case 4: return 1;
            case 5:
            case 6:
            case 7:
            case 8: return 0.9;
            case 9: return 0.8;
            case 10: return 0.77;
            default: throw new Exception("enter valid speed");

        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        return 221 * speed * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double productionRate = ProductionRatePerHour(speed);
        double product =  productionRate / 60;
        return (int) product;
    }
}
