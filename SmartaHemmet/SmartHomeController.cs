using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        
        public void ScheduleDevice(DateTime time)
        {
            foreach (Appliance device in _devices) if (device is ISchedulable)
                    Console.WriteLine(device.Schedule(time));
        }

        public void AddDevice(Appliance device)
        {
            // TODO-DONE:
            // Lägg till device i listan.
            _devices.Add(device);
        }
        public void TurnOnAll()
        {
            // TODO-DONE:
            // Loopa igenom alla devices och starta dem.
            // Du får inte använda if/switch på specifika klasser.
            foreach (Appliance device in _devices) device.TurnOn(); 
            
        }
        public void TurnOffAll()
        {
            // TODO-DONE:
            // Loopa igenom alla devices och stäng av dem.
            foreach (Appliance device in _devices) device.TurnOff();
        }
        public void PrintStatusReport()
        {
            // TODO-DONE:
            // Loopa igenom alla devices.
            // Skriv ut GetInfo() och om apparaten är på eller av.
            foreach (Appliance device in _devices) Console.WriteLine(device.GetInfo());
        }
        public double GetTotalDailyEnergyUsage()
        {
            // TODO:
            // Räkna ihop GetDailyEnergyUsage() för alla devices.
            // Returnera totalsumman.
            double totalEnergy = 0;
            foreach (Appliance device in _devices) totalEnergy += device.GetDailyEnergyUsage();
            return totalEnergy;
        }
    }
}
