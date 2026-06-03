using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SmartaHemmet
{
    internal class Washer(string brand, int capacityKg)
    {
        public string? Brand { get; set; } = brand;
        public int CapacityKg { get; set; } = capacityKg;
        public double WashEnergy { get; set; } = 1.2;

        public void StartWash() {
            Console.WriteLine($"Startar tvättmaskin {Brand}, med kapacitet {CapacityKg} kg.");
        }
        public void StopWash()
        {
            Console.WriteLine($"Stoppar tvättmaskin {Brand}.");
        }
        public void PrintWashEnergy()
        {
            Console.WriteLine($"Tvättmaskin {Brand} har förbrukat {WashEnergy} kWh per tvätt.");
        }
    }
}
