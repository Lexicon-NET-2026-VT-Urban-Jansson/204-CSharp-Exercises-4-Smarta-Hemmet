using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Refrigerator(int temperature, string brand, string room) : Appliance(brand, room)
    {
        public int Temperature { get; } = temperature;
        public double CoolingEnergy { get; } = 3.6;

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Kylskåp {base.Brand} startas i {base.Room}, med temperatur {Temperature} °C.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av kylskåp {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return CoolingEnergy;
        }
    }
}
