namespace loops_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string stringValue = Console.ReadLine();
            string outputOne= "";
            string outputTwo = " ";
            for(int i = 0;i<stringValue.Length;i++)
            {
                 if (i%2 == 0) {
                    outputOne += stringValue[i];
                }
                 else
                {
                    outputTwo += stringValue[i];
                }
            }
            Console.WriteLine(outputOne + " " +  outputTwo);
        }
    }
}
