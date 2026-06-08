
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

        Appliance foundDevice = controller.FindDeviceByBrand("Moccamaster One Switch"); // "Electrolux 900" != schedulable
        if (foundDevice != null) foundDevice.TurnOn();
        Console.WriteLine();

        //var flexRun = DateTime.Now;
        //List <ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
        //foreach (ISchedulable schedulable in schedulableDevices)
        //{
        //    // TODO-DONE:
        //    // Skriv ut NextRun eller schemalägg apparaten.
        //    //
        //    // Vill köra maskinerna nästa dag...
        //    var scheduledTime = flexRun.AddHours(24);
        //    schedulable.Schedule(scheduledTime);
        //    // Med lite mellanrum...
        //    flexRun = flexRun.AddHours(2);
        //}
        //Console.WriteLine();


        //controller.ScheduleDevice(DateTime.Now.AddHours(2));
        //Console.WriteLine();

        //SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);
        //Appliance lamp2 = lamp1;
        //lamp1.TurnOn();
        //lamp2.TurnOn();

        //PizzaOven pizzaOven = new PizzaOven(450, "Pop Pizza", "köket");
        //pizzaOven.TurnOn();

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
// *** FRÅGOR & SVAR  - Efter Del 1 ***
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
*/
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR  - Efter Del 5 ***
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
// *** FRÅGOR & SVAR - Efter Del 11: Labb ***
// ----------------------------------------------------------------------------
/*
1. Blir utskriften samma?
Nej.

2. Vilken metod körs när variabeln har typen SmartLamp?
SmartLamp -> TurnOn()

3. Vilken metod körs när variabeln har typen Appliance?
Appliance -> TurnOn()

4. Varför är detta farligt eller förvirrande?
Kan bli riktigt bökigt, om det är mycket kod, 
att hålla reda på vad som är castat till vad (eller inte).

5. Vad händer om du byter new till override?
Då beter sig SmartLamp som 'förväntat', 
dvs den kör samma kod oavsett casting.

Skriv en kommentar som förklarar detta med dina egna ord:
// new gömmer basklassens metod.
New skapar en ny instans av 'överklassen' med samma namn, 
och döljer därmed basklassen.

// override ersätter basklassens metod polymorfiskt.
Override utökar implementeringen med arv från basklassen.

*/
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR - Efter Del 12: Labb ***
// ----------------------------------------------------------------------------
/*
1. Vad säger kompilatorn?
"cannot override inherited member because it is sealed"

2. Varför får PizzaOven inte override:a TurnOn()?
"A member cannot override a sealed inherited member."

3. När kan det vara rimligt att använda sealed override?
Om man vid arv vill hindra att det i subklass görs override på utvalda metoder 
och/eller properties i en basklass.

4. Vad kan PizzaOven fortfarande göra i stället? Kan den override:a någon annan metod?
Ja, PizzaOven kan göra override på GetInfo(), TurnOff() och GetDailyEnergyUsage().

*/
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// *** FRÅGOR & SVAR - Efter Del 13: Labb ***
// ----------------------------------------------------------------------------
/*
Fråga: Varför kan listan vara List<ISchedulable> även om objekten egentligen är olika klasser?
Därför att GetSchedulableDevices() returnerar bara objekt som är ISchedulable.

*/
// ----------------------------------------------------------------------------
