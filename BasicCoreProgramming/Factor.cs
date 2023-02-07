using System;
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
            int count = 0;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i * i == 0)
                    Console.WriteLine("PrimeFactor of number is {0}", i);
                count++;
            }
            if(count ==0)
            Console.WriteLine("There is no a prime factor of {0}", number);
        }
    }
}
