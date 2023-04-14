using System.Collections;

namespace Baseball_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] operation= { "5", "-2", "4", "C", "D", "9", "+", "+" };

            Stack<int> stack = new Stack<int>();
            foreach (string item in operation)
            {

                if (item == "C")
                {
                    stack.Pop();

                }
                else if (item == "D")
                {
                    stack.Push(2 * stack.Peek());
                }
                else if (item == "+")
                {

                    int prevOne = stack.Pop();
                    int prevTwo = stack.Peek();
                    stack.Push(prevOne);
                    stack.Push(prevOne + prevTwo);
                }
                else
                {
                    stack.Push(int.Parse(item));
                }
            }

                int sum = 0;
                while (stack.Count > 0)
                {
                    sum += stack.Pop();
                }

                Console.WriteLine(sum);
            
        }
    }
}