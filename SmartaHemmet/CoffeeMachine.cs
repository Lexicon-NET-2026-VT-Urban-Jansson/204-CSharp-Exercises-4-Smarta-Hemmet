using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class CoffeeMachine(int cupsPerBrew, string brand, string room) : Appliance(brand, room)
    {
        public int CupsPerBrew { get; } = cupsPerBrew;    // Read-only public property
        public double BrewingEnergy { get; } = 0.3;

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Kaffemaskin {base.Brand} startas i {base.Room}, med kapacitet {CupsPerBrew} koppar per bryggning.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av kaffemaskin {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return BrewingEnergy;
        }
    }
}
