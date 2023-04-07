using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_oops
{
    public class Grandfather
    {
        public int age;
        public Grandfather(int age)
        {
            this.age = age;
        }
        public void DisplayGrandFather()
        {
            Console.WriteLine("Grandfather age is {0} times that of father.",age);
        }
    }
    public class Father : Grandfather
    {
        public int period;
        public Father(int age,int period):base(age) { 
                this.period = period;
        }
        public void DisplayFather()
        {
            Console.WriteLine("Father was at the period of {0}  with an age of {1}.",period,age);
        }
    }
    public class Son : Father
    {
        public Son(int age,int period):base (age,period) { }
        public void DisplayChild()
        {
            Console.WriteLine("Son was at the period of {0}'s with an age of {1}.",period,age);
        }
    }
}
