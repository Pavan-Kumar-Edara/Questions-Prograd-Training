namespace partial_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass employeeOne = new PartialClass();
            employeeOne.employeeName = "John";
            employeeOne.employeeId = 5;
            employeeOne.Display();

            PartialClass employeeTwo = new PartialClass();
            employeeTwo.employeeName = "Ro";
            employeeTwo.employeeId = 2;
            employeeTwo.Display();
            
        }
    }
}