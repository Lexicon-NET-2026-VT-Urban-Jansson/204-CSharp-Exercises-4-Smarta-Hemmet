using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace SmartaHemmet
{
    internal class AirConditioner(int targetTemperature, string brand, string room) : Appliance(brand, room), ISchedulable
    {
        public int TargetTemperature { get; } = targetTemperature;
        public double EnergyPerDay{ get; } = 12;
        public DateTime NextRun { get; set; }

        public void Schedule(DateTime time)
        {
            NextRun = time;
            Console.WriteLine($"Luftkonditionering {base.Brand} har schemalagts att startas " +
                NextRun.ToString("ddd d MMM") + " kl. " + NextRun.ToString("HH:mm") + ".");
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
        public override void TurnOn()
        {
            Console.WriteLine($"Luftkonditionering {base.Brand} startas i {base.Room}, med temperatur {TargetTemperature}°C.");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av luftkonditionering {base.Brand} i {base.Room}.");
        }
        public override double GetDailyEnergyUsage()
        {
            return EnergyPerDay;
        }
    }

}
