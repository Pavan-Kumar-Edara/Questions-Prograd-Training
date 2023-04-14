using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Methods
{
    public partial class Partial
    {
        public void Display() {
            Console.WriteLine("Partial Methods.");
        }
        public partial void Add(int numOne, int numTwo);

       
    }
    public partial class Partial
    {
        public void Addition(int numOne,int numTwo)
        {
            Add(numOne,numTwo);
        }
        public partial void Add(int numOne,int numTwo)
        {
            int result = numOne + numTwo;
            Console.WriteLine("Addition of two numbers is:"+result);
        }
    }
}
