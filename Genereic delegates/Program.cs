namespace Genereic_delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> add = (valueOne, valueTwo) =>
            {
                return valueOne + valueTwo;
            };
            int sum = add(10, 20);
            Console.WriteLine("Func delegate: " + sum);


            Action<int, double> againAdd = (valueOne, valueTwo) =>
            {
                var result = valueOne + valueTwo;
                Console.WriteLine("Action delegate:"+result);
            };
            againAdd(30, 20.5);

            Predicate<int> isEven = (x) => x % 2 == 0;
            bool result = isEven(10);
            Console.WriteLine("Predicate delegate: " + result);

        }
    }
}