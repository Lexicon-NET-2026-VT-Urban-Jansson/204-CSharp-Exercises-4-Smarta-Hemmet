using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    public class Appliance
    {
        public string Brand { get; }
        public string Room { get; }
        public bool IsOn { get; protected set; }
        public Appliance(string brand, string room)
        {
            // TODO-DONE:
            // Sätt Brand, Room och IsOn.
            Brand = brand;
            Room = room;
            IsOn = false;
        }

        // OBS! Detta ska INTE ligga här! Då kommer ALLA få en Schedule() = FEL!
        //public virtual void Schedule(DateTime time) { }

        public virtual string GetInfo()
        {
            // TODO-DONE:
            // Returnera en generell text om apparaten.
            // Exempel: "LG in Laundry room"
            string isOn = IsOn ? "på" : "av";
            return $"{Brand} är {isOn} i {Room}.";
        }
        public virtual void TurnOn()
        {
            // TODO-DONE:
            // Sätt IsOn till true.
            // Skriv ut ett generellt startmeddelande.
            IsOn = true;
            Console.WriteLine($"Startar {Brand}.");
        }
        public virtual void TurnOff()
        {
            // TODO-DONE:
            // Sätt IsOn till false.
            // Skriv ut ett generellt stoppmeddelande.
            IsOn = false;
            Console.WriteLine($"Stoppar {Brand}.");
        }
        public virtual double GetDailyEnergyUsage()
        {
            // TODO-DONE:
            // Returnera 0 som standardvärde.
            return 0;
        }
    }
}
