using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class RobotVacuum(string brand, int batteryLevel)
    {
        public string? Brand { get; set; } = brand;
        public int BatteryLevel { get; set; } = batteryLevel;

        public void StartCleaning()
        {
        }
        public void StopCleaning()
        {
        }
        public void PrintCleaningEnergy()
        {
        }
    }

}
