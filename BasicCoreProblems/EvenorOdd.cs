﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class EvenorOdd
    {
        public static void EvenOrOddCheck()
        {

            Console.WriteLine("Enter The Number To Check");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {

                Console.WriteLine("Number is even:" + n);
            }
            else
            {
                Console.WriteLine("Number is Odd:" + n);
            }
        }
    }

}
