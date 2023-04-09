using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_weekend_work_
{
    public class Car
    {
        public double fuelLevel = 20.0; 
        public const double maxTankSize = 60.0; 

        public bool isRunning = false; 
        public double fuelConsumption = 0.0003; 

        public void StartEngine()
        {
            isRunning = true;
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            isRunning = false;
            Console.WriteLine("Car engine stopped.");
        }

        public void AboutRunning(int seconds)
        {
            if (isRunning)
            {
                double fuelUsed = fuelConsumption * seconds;
                fuelLevel -= fuelUsed;

                if (fuelLevel <= 0)
                {
                    StopEngine();
                    fuelLevel = 0;
                    Console.WriteLine("Car has run out of fuel and stopped.");
                }
                else if (fuelLevel < 5)
                {
                    Console.WriteLine("Warning: Fuel level is low.");
                }
            }
            else
            {
                Console.WriteLine("Car engine is not running.");
            }
        }

     
        public double GetFuelTankSize()
        {
            return maxTankSize;
        }

        public double GetFuelTankLevel()
        {
            return Math.Round(fuelLevel, 2);
        }
    }
}









