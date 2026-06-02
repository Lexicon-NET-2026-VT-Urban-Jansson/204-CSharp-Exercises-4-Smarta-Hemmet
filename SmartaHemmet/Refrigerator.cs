using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Refrigerator(string brand, int temperature)
    {
        private string? _brand { get; set; } = brand;
        private int _temperature { get; set; } = temperature;
        private int _coolingEnergy { get; set; } = 2;

        public void StartCooling()
        {
            Console.WriteLine($"Startar kylskåp {_brand}, med temperatur {_temperature} °C.");
        }
        public void StopCooling()
        {
            Console.WriteLine($"Stoppar kylskåp {_brand}.");
        }
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"Kylskåp {_brand} har förbrukat {_coolingEnergy} kWh.");
        }
    }
}
