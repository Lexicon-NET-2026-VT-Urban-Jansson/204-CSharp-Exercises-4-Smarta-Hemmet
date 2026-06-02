using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Oven(string brand, int maxTemperature)
    {
        private string? _brand { get; set; } = brand;
        private int _maxTemperature { get; set; } = maxTemperature;
        private int _heatingEnergy { get; set; } = 2;

        public void StartHeating()
        {
            Console.WriteLine($"Startar ugn {_brand}, med maxtemperatur {_maxTemperature} °C.");
        }
        public void StopHeating()
        {
            Console.WriteLine($"Stoppar ugn {_brand}.");
        }
        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"Ugn {_brand} har förbrukat {_heatingEnergy} kWh.");
        }
    }
}
