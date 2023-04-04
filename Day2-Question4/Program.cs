namespace Day2_Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string stringValue = Console.ReadLine();

            char maxChar = '\0';
            int maxCount = 0;


            for (int i = 0; i < stringValue.Length; i++)
            {
                char c = stringValue[i];


                int count = 1;
                for (int j = i + 1; j < stringValue.Length; j++)
                {
                    if (stringValue[j] == c)
                    {
                        count++;
                    }
                }


                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = c;
                }
            }


            Console.WriteLine("The maximum repeated character in '{0}' is '{1}' and it appears {2} times", stringValue, maxChar, maxCount);
        }
    }
}
    
