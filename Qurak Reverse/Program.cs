namespace week1_day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Interact:");
            Quark quarkObjOne=new Quark("red","up");
            quarkObjOne.DisplayColorFlavor();

            Quark quarkObjTwo = new Quark("blue", "strange");
            quarkObjTwo.DisplayColorFlavor();
            Console.WriteLine();

            Console.WriteLine("After Interact");
            quarkObjOne.Interact(quarkObjTwo);
            quarkObjOne.DisplayColorFlavor();
            quarkObjTwo.DisplayColorFlavor();

        }
    }
}