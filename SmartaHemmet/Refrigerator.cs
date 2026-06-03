using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class Refrigerator(string brand, int temperature)
    {
        public string? Brand { get; set; } = brand;
        public int Temperature { get; set; } = temperature;
        public double CoolingEnergy { get; set; } = 3.6;

        public void StartCooling()
        {
            Console.WriteLine($"Startar kylskåp {Brand}, med temperatur {Temperature} °C.");
        }
        public void StopCooling()
        {
            Console.WriteLine($"Stoppar kylskåp {Brand}.");
        }
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"Kylskåp {Brand} har förbrukat {CoolingEnergy} kWh.");
        }
    }
}
