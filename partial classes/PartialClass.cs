using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_classes
{
    public partial class PartialClass
    {
        
        public string employeeName { get; set; }
        public int employeeId { get; set; }

        public partial void Display();
    }

    public partial class PartialClass
    {
        public partial void Display()
        {
            Console.WriteLine("Name is:"+employeeName);
            Console.WriteLine("Id is "+employeeId);
        }
    }
}
