using System;

namespace Day1
{
    public class Program
    {
        static int totalFuelPerModule = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting fuel calculation module");
            //FirstPart();
            SecondPart();
        }
        private static void FirstPart()
        {
            var modulesInNeetOfCalibrating = GetInput();
            int totalFuelNeeded = 0;
            foreach(var module in modulesInNeetOfCalibrating){
                int moduleMass = Int32.Parse(module);
                int fuelNeededForModule = moduleMass/3 - 2;
                totalFuelNeeded+=fuelNeededForModule;
            }
            Console.WriteLine(totalFuelNeeded);
        }

        private static void SecondPart()
        {
            var modulesInNeetOfCalibrating = GetInput();
            int totalFuelToGetGoing = 0;
            foreach(var module in modulesInNeetOfCalibrating){
                totalFuelPerModule = 0;
                CalculateFuelRequirementBasedOnMass(Int32.Parse(module));
                totalFuelToGetGoing+=totalFuelPerModule;
            }
            Console.WriteLine(totalFuelToGetGoing);
        }

        private static void CalculateFuelRequirementBasedOnMass(int mass){ 
            int fuelNeededForModule = mass/3 - 2;
            if(fuelNeededForModule > 0 ){
                totalFuelPerModule+=fuelNeededForModule;
                CalculateFuelRequirementBasedOnMass(fuelNeededForModule);
            }
        }

        private static string[] GetInput(){
            var input = System.IO.File.ReadAllLines(@"input.txt");
            return input;
        }
    }
}
