
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

        controller.ScheduleDevice(DateTime.Now.AddHours(2));
        Console.WriteLine();

        //controller.PrintStatusReport();
        //Console.WriteLine();

        //controller.TurnOnAll();
        //Console.WriteLine();

        //double totalEnergy = controller.GetTotalDailyEnergyUsage();
        //Console.WriteLine($"Total daglig energiförbrukning: {totalEnergy} kWh.");
        //Console.WriteLine();

        //controller.TurnOffAll();
    }
}

// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR - Efter Del 9 ***
// ----------------------------------------------------------------------------
/*
0. Varför kompilerar inte detta? Svara som kommentar.
Därför att Schedule(time) finns inte Appliance, 
utan ligger specifikt i klasser med interfacet ISchedulable.

1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?
Därför att Schedule(time) inte finns i Appliance.

2. Varför fungerar det efter att vi castar till ISchedulable?
Därför alla klasser med interfacet ISchedulable med *måste* implementera 
"void Schedule(DateTime time);", annars får vi kompilatorfel:
'Washer' does not implement interface member 'ISchedulable.Schedule(DateTime)'

3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?
Appliance är bas-klassen för RobotVacuum, med många snitsiga metoder. 
ISchedulable är interfacet för RobotVacuum, som sätter upp regler för vad 
som måste implementeras i RobotVacuum.

4. Varför ska inte Schedule() ligga direkt i Appliance?
Jag gjorde tyvärr det först, men det blir helt fel, för då kommer ALLA som har 
Appliance som bas-klass även få tillgång till Appliance version av Schedule(), 
vilket ju enbart var tänkt för de som har interface ISchedulable.

5. Vad är skillnaden mellan arv och interface i det här exemplet?
Med arv erhålls properties och metoder, medan interface sätter upp regler 
för properties och metoder.
*/
// ----------------------------------------------------------------------------
// ----------------------------------------------------------------------------
