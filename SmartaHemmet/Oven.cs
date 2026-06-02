using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Oven(string brand, int maxTemperature)
    {
        public string? Brand { get; set; } = brand;
        public int MaxTemperature { get; set; } = maxTemperature;

        public void StartHeating()
        {
        }
        public void StopHeating()
        {
        }
        public void PrintHeatingEnergy()
        {
        }
    }
}
