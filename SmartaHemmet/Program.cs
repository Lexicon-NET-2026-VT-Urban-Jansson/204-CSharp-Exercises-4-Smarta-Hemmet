
using SmartaHemmet;
using System;
using System.Collections.Generic;
class Program
{
    // ------------------------------------------------------------------------
    // *** Main ***
    // ------------------------------------------------------------------------
    static void Main()
    {
        // TODO-DONE:
        // Byt ut den gamla listan med object -> Appliance.
        List<Appliance> devices = new List<Appliance>();

        // TODO-DONE:
        // Lägg till Washer, Refrigerator, Oven, RobotVacuum och CoffeeMachine.
        devices.Add(new Washer(8, "Siemens iQ500", "tvättstugan"));
        devices.Add(new Refrigerator(4, "Electrolux 900", "köket"));
        devices.Add(new Oven(300, "Whirlpool OKZ9", "köket"));
        devices.Add(new RobotVacuum(95, "Roborock Qrevo Edge", "vardagsrummet"));
        devices.Add(new CoffeeMachine(10, "Moccamaster One Switch", "köket"));

        foreach (Appliance device in devices)
        {
            // TODO-DONE:
            // Skriv ut info.
            // Starta apparaten.
            // Skriv ut energiförbrukning.
            // Stäng av apparaten.        }
            device.GetInfo();
            device.TurnOn();
            Console.WriteLine($"Energiförbrukningen för {device.Brand} är {device.GetDailyEnergyUsage()} kWh.");
            device.TurnOff();
        }
    }
}

// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR - Frågor efter Del 5 ***
// ----------------------------------------------------------------------------
/*

1. Varför fungerar device.TurnOn() trots att device har typen Appliance?
Därför att Appliance har en virtuell metod som heter TurnOn(), 
som det sen görs override på i själva device’n (typ Washer), 
vilket möjliggör specifik anpassning för just den maskinen. 
Men rent generellt funkar det också att bara köra TurnOn() från Appliance, 
som ger |Console.WriteLine($"Startar {Brand}.");| då Brand är ett property i Appliance.

2. Vilken metod körs om objektet egentligen är en RobotVacuum?
RobotVacuum.TurnOn();

3. Vad blev bättre jämfört med List<object>?
Det blev mycket bättre, då slipper switch'a och cast'a för att hitta rätt device.

*/
// ----------------------------------------------------------------------------
// ----------------------------------------------------------------------------
