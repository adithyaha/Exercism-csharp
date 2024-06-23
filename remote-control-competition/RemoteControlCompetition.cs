using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

// TODO implement the IRemoteControlCar interface

public interface IRemoteControlCar
{
    public abstract void Drive();
    int DistanceTravelled { get; }
}



public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar> 
{ 
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other) => this.NumberOfVictories.CompareTo(other.NumberOfVictories); 
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2) => (prc1.CompareTo(prc2) > 0) ? [prc2, prc1] : [prc1, prc2];


}
