namespace RedRemoteControlCarTeam
{
    using Combined;
    public class RemoteControlCar
    {
        Motor motor;
        Chassis chassis;
        Telemetry telemetry;
        RunningGear runningGear;

        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry, RunningGear runningGear)
        {
            this.motor = motor;
            this.chassis = chassis;
            this.telemetry = telemetry;
            this.runningGear = runningGear;
        }


    }
}
namespace BlueRemoteControlCarTeam {
    using Combined;
    public class RemoteControlCar
    {
        Motor motor;
        Chassis chassis;
        Telemetry telemetry;

        public RemoteControlCar(Motor motor, Chassis chassis, Telemetry telemetry)
        {
            this.motor = motor;
            this.chassis = chassis;
            this.telemetry = telemetry;
        }


    }
}

namespace Combined{
    using BlueRemoteControlCarTeam;
    using RedRemoteControlCarTeam;
    public class RunningGear
    {
        // red members and API
    }

    public class Telemetry
    {
        // red members and API
    }

    public class Chassis
    {
        // red members and API
    }

    public class Motor
    {
        // red members and API
    }






    public static class CarBuilder
    {
        
        public static BlueRemoteControlCarTeam.RemoteControlCar BuildBlue() => new BlueRemoteControlCarTeam.RemoteControlCar(
                new Motor(),
                new Chassis(),
                new Telemetry()
            );
        

        public static RedRemoteControlCarTeam.RemoteControlCar BuildRed() => new RedRemoteControlCarTeam.RemoteControlCar (
                new Motor(),
                new Chassis(),
                new Telemetry(),
                new RunningGear()
                );
        };
    }
