﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgram
{
    class PrimeNumber
    {
        public static void Prime()
        {
            bool isPrime = true;
            int i, j;

            Console.WriteLine(" Prime Number Between 1 to 1000");
            Console.WriteLine("\n Prime Numbers are : ");

            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\n " + i);
                }
                isPrime = true;
            }
            
        }
    }
}
