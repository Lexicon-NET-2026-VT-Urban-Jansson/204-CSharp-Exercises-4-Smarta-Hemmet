using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Refrigerator(string brand, int temperature)
    {
        public string? Brand { get; set; } = brand;
        public int Temperature { get; set; } = temperature;

        public void StartCooling()
        {
        }
        public void StopCooling()
        {
        }
        public void PrintCoolingEnergy()
        {
        }
    }
}
