using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SmartaHemmet
{
    internal class Washer(int capacityKg, string brand, string room) : Appliance(brand, room)
    {
        public int CapacityKg { get; } = capacityKg;    // Read-only public property
        public double WashEnergy { get; } = 1.2;

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
