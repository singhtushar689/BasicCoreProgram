using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class QuotientRemainder
    {
        public void FindRemainder()
        {
            Console.WriteLine("Enter the dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if (dividend > divisor)
            {
                int quotient = dividend / divisor;
                Console.WriteLine("Quotient is " + quotient);
                int remainder = dividend % divisor;
                Console.WriteLine("Remainder is " + remainder);
            }
            else
            {
                Console.WriteLine("Divisor cannot be bigger than Dividend..Try Again!");
            }
        }
    }
}
