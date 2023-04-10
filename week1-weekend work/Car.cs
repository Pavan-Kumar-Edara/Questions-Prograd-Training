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

        public int accleration = 10;
        public int maxSpeed = 250;
        public int speed = 0;
        public double airResistance = 1.0;
        public double rollingResistance = 1.0;

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

        public void CalculateSpeed(double seconds)
        {
            double speed = accleration * seconds;
        }

        public double Getfuelconsumption()
        {
            if (speed >= 1 && speed <= 60)
            {
                return 0.0020;
            }
            else if (speed >= 61 && speed <= 100)
            {
                return 0.0014;
            }
            else if (speed >= 101 && speed <= 140)
            {
                return 0.0020;
            }
            else if (speed >= 141 && speed <= 200)
            {
                return 0.0025;
            }
            else if (speed >= 201 && speed <= 250)
            {
                return 0.0030;
            }
            else
            {
                return 0;
            }
        }

        //public void Brake()
        //{

        //}
       
            public void AboutRunning(double seconds)
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









