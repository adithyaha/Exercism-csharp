using System;

class RemoteControlCar
{
    int battery = 100;
    int distance = 0;
    
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar() {};
        
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.distance} meters";
    }

    public string BatteryDisplay()
    {
        if (this.battery == 0)
        {
            return $"Battery empty";
        }
        else
        {
            return $"Battery at {this.battery}%";
        }
    }

    public void Drive()
    {
        if (this.battery > 0)
        {
            this.distance += 20;
            this.battery--;
        }
        else
        {
            Console.WriteLine("Battery empty");
        }
        
    }
}
