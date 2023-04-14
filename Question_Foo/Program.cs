namespace Question
{
    public class foo
    {
     
        public static void first() { 
            Console.WriteLine("first");
        }
        public static void second() { 
            Console.WriteLine("second"); 
        }
        public static void third() {
            Console.WriteLine("third"); 
        }
        static void Main(string[] args)
        {
            
            int count = 3;
            List<int> list = new List<int>();
            for(int iterator=0; iterator<count; iterator++)
            {
                Console.WriteLine($"Enter value {iterator}:");
                list.Add(int.Parse(Console.ReadLine()));
            }
           

            //foo instance = new foo();

            Thread threadA = new Thread(first);
            Thread threadB = new Thread(second);
            Thread threadC = new Thread(third);

            for(int iterator=0; iterator < count; iterator++)
            {
                if (list[iterator] == 1)
                {
                     threadA.Start();
                }
                else if (list[iterator] == 2)
                {
                    threadB.Start();
                }
                else
                {
                    threadC.Start();
                }
            }
        }
    }
}


