﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Factor
    {
        public void Factors()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int factor;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine("{0} is divided by {1}", number, i);
            }
        }
    }
}
