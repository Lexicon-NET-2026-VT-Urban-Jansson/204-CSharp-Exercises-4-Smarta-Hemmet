
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
        List<object> devices = new List<object>();
        // TODO-DONE:
        // Skapa minst fyra objekt:
        // Washer, Refrigerator, Oven och RobotVacuum.
        // Lägg till dem i listan devices.
        devices.Add(new Washer(8, "Siemens iQ500", "tvättstugan" ));
        devices.Add(new Refrigerator(4, "Electrolux 900", "köket"));
        devices.Add(new Oven(300, "Whirlpool OKZ9", "köket"));
        devices.Add(new RobotVacuum(95, "Roborock Qrevo Edge", "vardagsrummet"));
        devices.Add(new CoffeeMachine(10, "Moccamaster One Switch", "köket"));

        RunMorningRoutine(devices);
        Console.WriteLine();
        ReportAllEnergy(devices);
    }

    // ------------------------------------------------------------------------
    // *** RunMorningRoutine ***
    // ------------------------------------------------------------------------
    static void RunMorningRoutine(List<object> devices)
    {
        foreach (object device in devices)
        {
            // TODO-DONE:
            // 1. Kontrollera vilken typ device är.
            // 2. Casta till rätt typ.
            // 3. Anropa rätt startmetod.
            // 4. Anropa rätt stoppmetod.

            switch (device)
            {
                // Pattern matching för att casta:
                // Washer washer = (Washer)device;
                case Washer washer:
                    washer.TurnOn();
                    washer.TurnOff();
                    break;

                // Pattern matching för att casta:
                // Refrigerator refrigerator = (Refrigerator)device;
                case Refrigerator refrigerator:
                    refrigerator.TurnOn();
                    refrigerator.TurnOff();
                    break;

                // Pattern matching för att casta:
                // Oven oven = (Oven)device;
                case Oven oven:
                    oven.TurnOn();
                    oven.TurnOff();
                    break;

                // Pattern matching för att casta:
                // RobotVacuum robotVacuum = (RobotVacuum)device;
                case RobotVacuum robotVacuum:
                    robotVacuum.TurnOn();
                    robotVacuum.TurnOff();
                    break;

                // Pattern matching för att casta:
                // CoffeeMachine coffeeMachine = (CoffeeMachine)device;
                case CoffeeMachine coffeeMachine:
                    coffeeMachine.TurnOn();
                    coffeeMachine.TurnOff();
                    break;
            }
        }
    }

    // ------------------------------------------------------------------------
    // *** ReportAllEnergy ***
    // ------------------------------------------------------------------------
    static void ReportAllEnergy(List<object> devices)
    {
        foreach (object device in devices)
        {
            // TODO-DONE:
            // 1. Kontrollera vilken typ device är.
            // 2. Casta till rätt typ.
            // 3. Anropa rätt energimetod.
        
            switch (device)
            {
                case Washer washer:
                    //washer.PrintWashEnergy();
                    break;
                case Refrigerator refrigerator:
                    //refrigerator.PrintCoolingEnergy();
                    break;
                case Oven oven:
                    //oven.PrintHeatingEnergy();
                    break;
                case RobotVacuum robotVacuum:
                    //robotVacuum.PrintCleaningEnergy();
                    break;
                case CoffeeMachine coffeeMachine:
                    //coffeeMachine.PrintBrewingEnergy();
                    break;
            }
        }
    }
}

// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR ***
// ----------------------------------------------------------------------------
/*
1. Varför behövde du kontrollera vilken typ varje objekt hade?
Utan typen kommer man inte åt metoderna.

2. Vad händer om du lägger till en ny klass CoffeeMachine?
Jag får ett nytt objekt i listan: List<object> devices

3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?
Main, RunMorningRoutine, ReportAllEnergy + metoderna i nya klassen CoffeeMachine.

4. Vad är problemet med att listan är List<object>?
Den är inte generell, om vi kört List<T> kunde vi stoppat in vad som helst, bananer, hundar, etc.

5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
Energiåtgången för den apparaten kommer inte rapporteras. 

6. När jag lade till CoffeeMachine behövde jag ändra...
Jag behövde ändra på tre ställen i class Program + den helt nya klassen CoffeeMachine.


*/
// ----------------------------------------------------------------------------
// ----------------------------------------------------------------------------
