
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
        SmartHomeController controller = new SmartHomeController();
        // TODO-DONE:
        // Lägg till minst fem olika apparater.
        controller.AddDevice(new Washer(8, "Siemens iQ500", "tvättstugan"));
        controller.AddDevice(new Refrigerator(4, "Electrolux 900", "köket"));
        controller.AddDevice(new Oven(300, "Whirlpool OKZ9", "köket"));
        controller.AddDevice(new RobotVacuum(95, "Roborock Qrevo Edge", "vardagsrummet"));
        controller.AddDevice(new CoffeeMachine(10, "Moccamaster One Switch", "köket"));

        controller.PrintStatusReport();
        Console.WriteLine();

        controller.TurnOnAll();
        Console.WriteLine();
        
        double totalEnergy = controller.GetTotalDailyEnergyUsage();
        Console.WriteLine($"Total daglig energiförbrukning: {totalEnergy} kWh.");
        Console.WriteLine();

        controller.TurnOffAll();
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
