﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7App
{
    class Program
    {
        static void Main(string[] args)
        {
            int number= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)

                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
