namespace Day1_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string stringValue = Console.ReadLine();
            string outputValue = "";
            for (int i = 0; i < stringValue.Length; i++)
            {

                if (stringValue[i] == 'a' || stringValue[i] == 'e' || stringValue[i] == 'i' || stringValue[i]
                    == 'o' || stringValue[i] == 'u' || stringValue[i] == 'A' || stringValue[i] == 'E' || stringValue[i] == 'I' || stringValue[i]
                    == 'O' || stringValue[i] == 'U')
                {
                    outputValue += "";
                }
                else
                {
                    outputValue += stringValue[i];
                }

            }
            Console.WriteLine(outputValue);
        }
    }
}