using System;

class RemoteControlCar
{
    private int TotalDistance;
    private int BatteryPercentage;
    public RemoteControlCar()
    {
        TotalDistance = 0;
        BatteryPercentage = 100;
    }
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {TotalDistance} meters";
    }

    public string BatteryDisplay()
    {
        return BatteryPercentage==0? "Battery empty": $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {
        if (BatteryPercentage != 0)
        {
            TotalDistance += 20;
            BatteryPercentage -= 1;
        }
       
    }
}
