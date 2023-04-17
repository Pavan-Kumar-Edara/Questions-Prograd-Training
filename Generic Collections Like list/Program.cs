namespace Generic_Collections_Like_list
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for (int iterator = 0; iterator < size; iterator++)
            {
                array[iterator] = int.Parse(Console.ReadLine());
            }

            Loop<int> loop = new Loop<int>();
            Console.WriteLine("To Rotate right:");

            loop.RotateRight(array, size);
            loop.display(array);

            Console.WriteLine("To Rotate left:");
            loop.RotateLeft(array, size);

            loop.display(array);

            Console.WriteLine("To show first:");
            loop.Showfirst(array);

            Console.WriteLine("To pop first:");
            loop.PopFirst(array);


        }
    }
    
}

