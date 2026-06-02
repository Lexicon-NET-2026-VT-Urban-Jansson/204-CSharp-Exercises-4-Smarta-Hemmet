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

        public void StartWash() { 
        }
        public void StopWash()
        {
        }
        public void PrintWashEnergy()
        {
        }
    }
}
