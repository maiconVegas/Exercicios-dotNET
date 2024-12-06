using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.elons_toys
{
    internal class RemoteControlCar
    {
        private int _meters = 0;
        private int _baterry = 100;
        public static RemoteControlCar Buy() => new RemoteControlCar();

        public string DistanceDisplay() => $"Driven {_meters} meters";

        public string BatteryDisplay() => _baterry == 0 ? "Battery empty" : $"Battery at {_baterry}%";

        public void Drive()
        {
            if (_baterry > 0)
            {
                _meters += 20;
                _baterry -= 1;
            }
        }
    }
}
