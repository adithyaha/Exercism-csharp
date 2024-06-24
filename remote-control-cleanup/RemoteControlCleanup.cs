public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed currentSpeed;

    // TODO encapsulate the methods suffixed with "_Telemetry" in their own class
    // dropping the suffix from the method name

    public RemoteControlCar()
    {
        Telemetry = new Telemetry(this);
    }
    
    public Telemetry Telemetry { get; private set; }

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    public void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    public void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}


public class Telemetry
{
    private readonly RemoteControlCar _car;

    public Telemetry(RemoteControlCar car)
    {
        _car = car;
    }

    public void Calibrate() { }
    public bool SelfTest() => true;
    public void ShowSponsor(string sponsorName)
    {   
        _car.SetSponsor(sponsorName);
    }
    public void SetSpeed(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
        if (unitsString == "cps")
        {
            speedUnits = SpeedUnits.CentimetersPerSecond;
        }

        _car.SetSpeed(new Speed(amount, speedUnits));
    }



}


public struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }

    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
        {
            unitsString = "centimeters per second";
        }

        return Amount + " " + unitsString;
    }
}
