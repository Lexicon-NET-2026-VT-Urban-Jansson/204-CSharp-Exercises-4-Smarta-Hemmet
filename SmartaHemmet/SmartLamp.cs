using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }
        public SmartLamp(string brand, string room, int brightness) : base(brand, room)
        {
            // TODO-DONE:
            // Spara brightness.
            Brightness = brightness;
        }
        public override void TurnOn()
        // public new void TurnOn()
        {
            // TODO-DONE:
            // Skriv ut att lampan tänds.
            Console.WriteLine("Lampan tänds.");
        }
    }
}
