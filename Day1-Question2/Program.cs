namespace Day1_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(n);
            int lowerSquare = sqrt * sqrt;
            int upperSquare = (sqrt + 1) * (sqrt + 1);
            if (n == lowerSquare)
            {
                Console.WriteLine(n);
                Console.WriteLine(Math.Sqrt(n));
            }
            else
            {

                if (n - lowerSquare < upperSquare - n)
                {
                    Console.WriteLine(lowerSquare);
                    Console.WriteLine(Math.Sqrt(lowerSquare));
                }
                else
                {
                    Console.WriteLine(upperSquare);
                    Console.WriteLine(Math.Sqrt(upperSquare));

                }
            }
        }
    }
}