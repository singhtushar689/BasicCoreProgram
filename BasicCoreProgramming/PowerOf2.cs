using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOf2
    {
        public void Power()
        {
            int times = 31;
            int number = 2;
            double powerOf2;
            for(int i =1; i <= times; i++)
            {
                powerOf2 = Math.Pow(number,i);
                Console.WriteLine(powerOf2);
            }
        }
    }
}
