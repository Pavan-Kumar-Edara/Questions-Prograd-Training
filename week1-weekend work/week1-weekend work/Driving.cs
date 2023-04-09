using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_weekend_work_
{
    public class Driving
    {
        private string color;
        private double tank_size;
        private double consumption;
        private double acceleration;
        private double speed;
        private double fuel;

        public Driving(string color, double tank_size = 50, double consumption = 0.0020, double acceleration = 10)
        {
            this.color = color;
            this.tank_size = tank_size;
            this.consumption = consumption;
            this.acceleration = acceleration;
            this.speed = 0;
            this.fuel = tank_size;
        }

        public string GetColor()
        {
            return color;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public double GetFuel()
        {
            return fuel;
        }

        public void SetAcceleration(double acceleration)
        {
            this.acceleration = Math.Max(Math.Min(acceleration, 20), 5);
        }

        public bool Accelerate(double seconds)
        {
            if (fuel <= 0)
            {
                return false;
            }
            double acceleration = Math.Min(seconds * this.acceleration, 10);
            speed += acceleration;
            if (speed > 250)
            {
                speed = 250;
            }
            fuel -= speed * consumption * seconds;
            return true;
        }

        public bool Brake(double speed, double seconds)
        {
            if (this.speed <= 0)
            {
                return false;
            }
            double braking = Math.Min((this.speed - speed) / seconds, 10);
            this.speed -= braking;
            if (this.speed < 0)
            {
                this.speed = 0;
            }
            return true;
        }

        public bool Freewheel(double seconds)
        {
            double resistance = 1; 
            speed -= resistance * seconds;
            if (speed < 0)
            {
                speed = 0;
            }
            return true;
        }

        public void Refuel()
        {
            fuel = tank_size;
        }

        public override string ToString()
        {
            return $"Color: {color}, Speed: {speed} km/h, Fuel: {fuel} L";
        }
    }
}
