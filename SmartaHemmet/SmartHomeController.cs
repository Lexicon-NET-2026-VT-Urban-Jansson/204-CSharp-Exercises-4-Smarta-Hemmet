using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace SmartaHemmet
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        public Appliance FindDeviceByBrand(string brand)
        {
            // TODO:
            // Returnera första apparaten med rätt brand.
            // Om ingen finns kan du returnera null,
            // eller kasta ett eget felmeddelande.
            //throw new NotImplementedException();   
            
            Appliance foundDevice = null;
            foreach (Appliance device in _devices)
            {
                if (device.Brand == brand)
                {
                    foundDevice = device;
                    if (device is ISchedulable schedulable) schedulable.Schedule(DateTime.Now.AddHours(24));
                    break;
                }
            }
            return foundDevice!;
        }

        internal List<ISchedulable> GetSchedulableDevices()
        {
            List<ISchedulable> result = new List<ISchedulable>();
            foreach (Appliance device in _devices)
            {
                // TODO-DONE:
                // Om device implementerar ISchedulable,
                // lägg till det i result.
                if (device is ISchedulable schedulable) result.Add(schedulable);
            }
            return result;
        }

        public void ScheduleDevice(DateTime time)
        {
            foreach (Appliance device in _devices)
            {
                // Casta: device -> ISchedulable -> schedulable
                if (device is ISchedulable schedulable) schedulable.Schedule(time);
            }

            // Detta funkar inte!
            //
            // foreach (Appliance device in _devices)
            // {
            //     // INTE Castat!
            //     device.Schedule(time);
            // }
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
            // TODO-DONE:
            // Räkna ihop GetDailyEnergyUsage() för alla devices.
            // Returnera totalsumman.
            double totalEnergy = 0;
            foreach (Appliance device in _devices) totalEnergy += device.GetDailyEnergyUsage();
            return totalEnergy;
        }
    }
}
