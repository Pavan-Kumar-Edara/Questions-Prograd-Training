namespace Day2_Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter begin value:");
            int begin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end value:");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter step value:");
            int step = int.Parse(Console.ReadLine());

            if (begin > end)
            {
                Console.WriteLine("0");
            }

            int res = 0;
            int i = begin;
            while (i <= end)
            {
                res += i;
                i += step;
            }

            Console.WriteLine(res);
        }
    }
}
