using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SmartaHemmet
{
    internal class Washer(string brand, int capacityKg)
    {
        private string? _brand { get; set; } = brand;
        private int _capacityKg { get; set; } = capacityKg;
        private int _washEnergy { get; set; } = 2;

        public void StartWash() {
            Console.WriteLine($"Startar tvättmaskin {_brand}, med kapacitet {_capacityKg} kg.");
        }
        public void StopWash()
        {
            Console.WriteLine($"Stoppar tvättmaskin {_brand}.");
        }
        public void PrintWashEnergy()
        {
            Console.WriteLine($"Tvättmaskin {_brand} har förbrukat {_washEnergy} kWh.");
        }
    }
}
