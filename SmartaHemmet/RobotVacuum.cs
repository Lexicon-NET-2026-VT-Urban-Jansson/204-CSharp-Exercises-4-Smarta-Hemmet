using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class RobotVacuum(string brand, int batteryLevel)
    {
        public string? Brand { get; set; } = brand;
        public int BatteryLevel { get; set; } = batteryLevel;
        public double CleaningEnergy { get; set; } = 0.4;

        public void StartCleaning()
        {
            Console.WriteLine($"Startar robotdammsugare {Brand}, med batterinvå {BatteryLevel} %.");
        }
        public void StopCleaning()
        {
            Console.WriteLine($"Stoppar robotdammsugare {Brand}.");
        }
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"Robotdammsugare {Brand} har förbrukat {CleaningEnergy} kWh.");
        }
    }

}
