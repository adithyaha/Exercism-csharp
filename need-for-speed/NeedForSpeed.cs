using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;

class RemoteControlCar
{
    public int SpeedOfCar;
    public int BatteryDrainPercentage;
    public int battery;
    public int distanceDriven;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speedOfCar, int batteryDrainPercentage)
    {
        this.SpeedOfCar = speedOfCar; 
        this.BatteryDrainPercentage = batteryDrainPercentage;
        this.distanceDriven = 0;
        this.battery = 100;
       
    }

    public bool BatteryDrained()
    {
        return this.battery < BatteryDrainPercentage;
    }

    public int DistanceDriven()
    {
        return this.distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.battery -= this.BatteryDrainPercentage;
            this.distanceDriven += this.SpeedOfCar;
        }
        
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int TrackDistance;
    public RaceTrack(int distance)
    {
        this.TrackDistance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maximumPossibleDistance = (100 / car.BatteryDrainPercentage) * car.SpeedOfCar;
        return maximumPossibleDistance >= TrackDistance;
        
    }
}
