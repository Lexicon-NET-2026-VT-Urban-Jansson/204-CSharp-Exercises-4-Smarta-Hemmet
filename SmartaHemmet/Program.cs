
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
        devices.Add(new Washer("Siemens iQ500", 8));
        devices.Add(new Refrigerator("Electrolux 900", 4));
        devices.Add(new Oven("Whirlpool OKZ9", 300));
        devices.Add(new RobotVacuum("Roborock Qrevo Edge", 95));
        devices.Add(new CoffeeMachine("Moccamaster One Switch", 10));

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
                    washer.StartWash();
                    washer.StopWash();
                    break;

                // Pattern matching för att casta:
                // Refrigerator refrigerator = (Refrigerator)device;
                case Refrigerator refrigerator:
                    refrigerator.StartCooling();
                    refrigerator.StopCooling();
                    break;

                // Pattern matching för att casta:
                // Oven oven = (Oven)device;
                case Oven oven:
                    oven.StartHeating();
                    oven.StopHeating();
                    break;

                // Pattern matching för att casta:
                // RobotVacuum robotVacuum = (RobotVacuum)device;
                case RobotVacuum robotVacuum:
                    robotVacuum.StartCleaning();
                    robotVacuum.StopCleaning();
                    break;

                // Pattern matching för att casta:
                // CoffeeMachine coffeeMachine = (CoffeeMachine)device;
                case CoffeeMachine coffeeMachine:
                    coffeeMachine.StartBrewing();
                    coffeeMachine.StopBrewing();
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
                    washer.PrintWashEnergy();
                    break;
                case Refrigerator refrigerator:
                    refrigerator.PrintCoolingEnergy();
                    break;
                case Oven oven:
                    oven.PrintHeatingEnergy();
                    break;
                case RobotVacuum robotVacuum:
                    robotVacuum.PrintCleaningEnergy();
                    break;
                case CoffeeMachine coffeeMachine:
                    coffeeMachine.PrintBrewingEnergy();
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
