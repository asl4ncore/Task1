﻿using System;
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
            CondtitionPart2 condition = new CondtitionPart2();
            condition.ComparisonNumbers(number);
            Console.ReadKey();
        }
    }
}