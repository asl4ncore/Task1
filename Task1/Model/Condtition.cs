using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class Condtition
    {
        public int Number { get; set; }
        public Condtition()
        {
            if (Number % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            if (Number % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            if (Number % 5 == 0 && Number % 3 == 0)
            {
                Console.WriteLine("FooBar");
            }
        }
        public virtual void ComparisonNumbers(int Number)
        {

        }

    }


    public class CondtitionPart2: Condtition
    {
        public override void ComparisonNumbers(int Number)
        {
            if (Number % 7 == 0 && Number % 3 == 0)
            {
                Console.WriteLine("FooLoo");
            }
            if (Number % 7 == 0 && Number % 5 == 0)
            {
                Console.WriteLine("BarLoo");
            }
            if (Number % 7 == 0 && Number % 5 == 0 && Number % 3 == 0)
            {
                Console.WriteLine("FooBarLoo");
            }
        }

    }
}
