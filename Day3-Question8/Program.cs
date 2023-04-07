namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string stringvalue=Console.ReadLine();

            if (stringvalue.Length <=4)
            {
                Console.WriteLine(stringvalue);
            }
            else
            {
                string outputString = "";
                for (int iteration = 0; iteration < stringvalue.Length - 4; iteration++)
                {
                    outputString += "#";
                }
                outputString += stringvalue.Substring(stringvalue.Length - 4);
                Console.WriteLine(outputString);
            }
        
        }
    }
}