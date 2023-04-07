namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outPut;
            Console.WriteLine("Enter a noun:");
            string noun=Console.ReadLine();

            if (noun[0] == noun[noun.Length-1])
            {
                outPut= char.ToUpper(noun[0]) + noun.Substring(1) + noun.Substring(1);
            }
            else
            {
                outPut = "The " + char.ToUpper(noun[0]) + noun.Substring(1); ;
            }

            Console.WriteLine(outPut);
        }
    }
}