using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            CondtitionPart2 runCondition = new CondtitionPart2();
            runCondition.ComparisonNumber(number);

            Console.ReadKey();
        }
    }
}
