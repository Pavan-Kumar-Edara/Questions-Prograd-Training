namespace Day4_oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Grandfather grandfather = new Grandfather(4);
            grandfather.DisplayGrandFather();

            Son son = new Son(10, 20);
            son.DisplayChild();
            son.DisplayGrandFather();

        }
    }
}