namespace Day2_Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outPut = " ";
            int skip = 0;
            Console.WriteLine("Enter  string");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    skip += 1;
                }
                else if (c == ')')
                {
                    skip -= 1;
                }
                else if (skip == 0)
                {
                    outPut += c;
                }
            }
            Console.WriteLine(outPut);
        }
    }
    
}