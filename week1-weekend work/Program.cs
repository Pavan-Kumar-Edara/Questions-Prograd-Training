namespace week1_weekend_work_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine("Car fuel level: {0} liters", myCar.GetFuelTankLevel());

            myCar.StartEngine();
           

            myCar.AboutRunning(500);
            Console.WriteLine("Car fuel level: {0} liters", myCar.GetFuelTankLevel());

            myCar.AboutRunning(1000000000);
            Console.WriteLine("Car fuel level: {0} liters", myCar.GetFuelTankLevel());

            myCar.StopEngine();
            
        }
    }
}
