using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.need_for_speed
{
    public class RemoteControlCar
    {
        // TODO: define the constructor for the 'RemoteControlCar' class
        private int speed;
        private int distance;
        private int battery;
        private int batteryDrain;
        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
            this.battery = 100;
            this.distance = 0;
        }

        public bool BatteryDrained() => battery <= 0 || battery < batteryDrain;

        public int DistanceDriven() => this.distance;

        public void Drive()
        {
            if (!BatteryDrained() && battery >= batteryDrain)
            {
                this.distance += speed;
                this.battery -= batteryDrain;
            }
        }

        public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    }

    class RaceTrack
    {
        // TODO: define the constructor for the 'RaceTrack' class
        private int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car) 
        {
            while (!car.BatteryDrained())
            {
                car.Drive();
            }
            return car.DistanceDriven() >= distance ? true: false;
        }
    }
}
