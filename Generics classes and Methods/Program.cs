namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> name = new GenericClass<string>();
            name.GenericMethod<string>("Generic Class.");

            GenericClass<int> count = new GenericClass<int>();
            count.GenericMethod<int>(1);

            GenericClass<char> firstLetter = new GenericClass<char>();
            firstLetter.GenericMethod('G');
        }
    }
}