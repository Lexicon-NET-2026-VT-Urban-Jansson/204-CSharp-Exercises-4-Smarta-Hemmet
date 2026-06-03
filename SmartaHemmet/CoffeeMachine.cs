using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    internal class CoffeeMachine(string brand, int cupsPerBrew)
    {
        public string? Brand { get; set; } = brand;
        public int CupsPerBrew { get; set; } = cupsPerBrew;
        public double BrewingEnergy { get; set; } = 0.3;

        public void StartBrewing()
        {
            Console.WriteLine($"Startar kaffemaskin {Brand}, med kapacitet {CupsPerBrew} koppar per bryggning.");
        }
        public void StopBrewing()
        {
            Console.WriteLine($"Stoppar kaffemaskin {Brand}.");
        }
        public void PrintBrewingEnergy()
        {
            Console.WriteLine($"Kaffemaskin {Brand} har förbrukat {BrewingEnergy} kWh per bryggning.");
        }
    }
}
