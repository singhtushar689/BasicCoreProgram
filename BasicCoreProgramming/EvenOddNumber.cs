using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class EvenOddNumber
    {
        public void Even()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("It is an Even Number");
            }
            else
            {
                Console.WriteLine("It is an Odd Number");
            }
        }
    }
}
