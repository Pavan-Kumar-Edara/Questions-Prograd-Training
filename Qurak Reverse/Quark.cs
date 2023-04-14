using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day5
{
    public class Quark
    {
        public string color;
        public string flavor;
        public double baryonNumber;
        
        public Quark(string color,string flavor)
        {
            this.color = color;
            this.flavor = flavor;
            this.baryonNumber = 1.0/3.0;
        }

        public void DisplayColorFlavor()
        {
            Console.WriteLine(color+","+flavor+","+baryonNumber);
        }
        public void Interact(Quark otherQuark)
        {
                string tempColor=this.color;
                this.color=otherQuark.color;
                otherQuark.color=tempColor;
        }


    }
}
