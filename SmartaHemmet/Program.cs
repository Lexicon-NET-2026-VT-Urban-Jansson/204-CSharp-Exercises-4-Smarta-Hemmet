namespace SmartaHemmet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Välkommen till det Smarta Hemmet!");

            // Testar Washer
            var washer = new Washer("Siemens iQ500", 8);
            washer.StartWash();
            washer.PrintWashEnergy();
            washer.StopWash();

            // Testar Refrigerator
            var refrigerator = new Refrigerator("Electrolux", 4);
            refrigerator.StartCooling();
            refrigerator.StopCooling();
            refrigerator.PrintCoolingEnergy();

            // Testar Oven
            var oven = new Oven("Whirlpool OKZ9", 300);
            oven.StartHeating();
            oven.StopHeating();
            oven.PrintHeatingEnergy();

            // Testar RobotVacuum
            var robotVacuum = new RobotVacuum("Roborock Qrevo Edge", 95);
            robotVacuum.StartCleaning();
            robotVacuum.StopCleaning();
            robotVacuum.PrintCleaningEnergy();
        }
    }
}
