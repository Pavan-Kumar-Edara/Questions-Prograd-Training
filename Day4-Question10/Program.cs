namespace Question
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = new int[3];
            Console.WriteLine("Enter width,length,height:");
            for (int iterator=0;iterator<dimensions.Length; iterator++)
            {
                dimensions[iterator] = int.Parse(Console.ReadLine());
            }
            
            Block blockCode = new Block(dimensions);

            Console.WriteLine("width: "+blockCode.GetWidth()); 
            Console.WriteLine("length: "+blockCode.GetLength());  
            Console.WriteLine("height: "+blockCode.GetHeight());  
            Console.WriteLine("volume: "+blockCode.GetVolume());  
            Console.WriteLine("surfacearea: "+blockCode.GetSurfaceArea());  
        }
    }
}
