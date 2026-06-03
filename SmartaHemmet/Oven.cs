using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Oven(string brand, int maxTemperature)
    {
        public string? Brand { get; set; } = brand;
        public int MaxTemperature { get; set; } = maxTemperature;
        public double HeatingEnergy { get; set; } = 2.5;

        public void StartHeating()
        {
            Console.WriteLine($"Startar ugn {Brand}, med maxtemperatur {MaxTemperature} °C.");
        }
        public void StopHeating()
        {
            Console.WriteLine($"Stoppar ugn {Brand}.");
        }
        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"Ugn {Brand} har förbrukat {HeatingEnergy} kWh per timme.");
        }
    }
}
