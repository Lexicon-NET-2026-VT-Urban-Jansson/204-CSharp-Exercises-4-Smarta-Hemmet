using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class CoffeeMachine(int cupsPerBrew, string brand, string room) : Appliance(brand, room), ISchedulable
    {
        public int CupsPerBrew { get; } = cupsPerBrew;
        public double BrewingEnergy { get; } = 0.3;
        public DateTime NextRun { get; set; }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"Kaffemaskin {base.Brand} har schemalagts att börja brygga kaffe " +
                NextRun.ToString("ddd d MMM") + " kl. " + NextRun.ToString("HH:mm") + ".");
        }

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
