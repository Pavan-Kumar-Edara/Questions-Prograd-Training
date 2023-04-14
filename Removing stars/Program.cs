namespace Removing_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string stringValue = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var item in stringValue)
            {

                if (item != '*')
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
            }

            char[] charArray = stack.ToArray();

            Array.Reverse(charArray);
            Console.WriteLine(charArray);


        }
    }
}