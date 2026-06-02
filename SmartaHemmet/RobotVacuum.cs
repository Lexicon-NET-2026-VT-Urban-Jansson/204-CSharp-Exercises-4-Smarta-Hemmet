using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class RobotVacuum(string brand, int batteryLevel)
    {
        private string? _brand { get; set; } = brand;
        private int _batteryLevel { get; set; } = batteryLevel;
        private int _cleaningEnergy { get; set; } = 2;

        public void StartCleaning()
        {
            Console.WriteLine($"Startar robotdammsugare {_brand}, med batterinvå {_batteryLevel} %.");
        }
        public void StopCleaning()
        {
            Console.WriteLine($"Stoppar robotdammsugare {_brand}.");
        }
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"Robotdammsugare {_brand} har förbrukat {_cleaningEnergy} kWh.");
        }
    }

}
