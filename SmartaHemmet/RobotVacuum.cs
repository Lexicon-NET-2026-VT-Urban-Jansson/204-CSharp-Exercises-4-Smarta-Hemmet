using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class RobotVacuum(int batteryLevel, string brand, string room) : Appliance(brand, room), ISchedulable
    {
        public int BatteryLevel { get; } = batteryLevel;
        public double CleaningEnergy { get; } = 0.4;
        public DateTime NextRun { get; set; }

        public override string Schedule(DateTime time)
        {
            NextRun = time;
            return $"Robotdammsugare {base.Brand} har schemalagts att börja städa " +
                NextRun.ToString("ddd d MMM") + " kl. " + NextRun.ToString("HH:mm") + ".";
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Robotdammsugare {base.Brand} startas i {base.Room}, med batterinvå {BatteryLevel} %.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Stänger av robotdammsugare {base.Brand} i {base.Room}.");
        }

        public override double GetDailyEnergyUsage()
        {
            return CleaningEnergy;
        }
    }
}
