using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Washer(int capacityKg, string brand, string room) : Appliance(brand, room), ISchedulable
    {
        public int CapacityKg { get; } = capacityKg;
        public double WashEnergy { get; } = 1.2;
        public DateTime NextRun { get; set; }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"Tvättmaskin {base.Brand} har schemalagts att starta ett tvättprogram " +
                NextRun.ToString("ddd d MMM") + " kl. " + NextRun.ToString("HH:mm") + ".");
        }

        public override string GetInfo() {
            return base.GetInfo();
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Tvättmaskin {base.Brand} startar ett tvättprogram i {base.Room}, med kapacitet {CapacityKg} kg per tvätt.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av tvättmaskin {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return WashEnergy;
        }
    }
}
