using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    public class Oven(int maxTemperature, string brand, string room) : Appliance(brand, room)
    {
        public int MaxTemperature { get; } = maxTemperature;    // Read-only public property
        public double HeatingEnergy { get; } = 2.5;

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override void TurnOn()
        //public sealed override void TurnOn()
        {
            Console.WriteLine($"Ugn {base.Brand} startas i {base.Room}, med maxtemperatur {MaxTemperature}°C.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av ugn {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return HeatingEnergy;
        }
    }

    public class PizzaOven : Oven
    {
        public PizzaOven(int maxTemperature, string brand, string room) : base(maxTemperature, brand, room)
        {
        }
        public override void TurnOn()
        {
            Console.WriteLine("Pizza oven starts at extra high temperature.");
        }
    }

}
