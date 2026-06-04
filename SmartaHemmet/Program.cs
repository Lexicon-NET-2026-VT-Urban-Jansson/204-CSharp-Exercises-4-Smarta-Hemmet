
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
        controller.AddDevice(new Dishwasher(15, "Bosch Serie 2", "köket"));

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
// *** FRÅGOR & SVAR - Efter Del 7 ***
// ----------------------------------------------------------------------------
/*

*/
// ----------------------------------------------------------------------------
// ----------------------------------------------------------------------------
