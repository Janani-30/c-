﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Divisible
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i + ",");
            }
            Console.ReadLine();
        }
    }
}
