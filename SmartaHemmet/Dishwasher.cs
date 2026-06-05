using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Dishwasher(int capacityPlaceSettings, string brand, string room) : Appliance(brand, room)
    {
        public int CapacityPlaceSettings { get; } = capacityPlaceSettings;
        public double DishwashEnergy { get; } = 1.4;

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Diskmaskin {base.Brand} startar ett diskprogram i {base.Room}, med kapacitet {CapacityPlaceSettings} kuvert.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av diskmaskin {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return DishwashEnergy;
        }
    }
}
