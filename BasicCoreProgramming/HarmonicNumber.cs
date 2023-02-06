using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the total terms you want");
            int term = Convert.ToInt32(Console.ReadLine());
            float number=0;
            float sum = 0;
            for(float i =1; i <= term; i++)
            {
                number = 1 / i;
                sum += number;
                Console.WriteLine( number);
                
            }
            Console.WriteLine("Sum of harmonic number is {0}",sum);

        }
    }
}
