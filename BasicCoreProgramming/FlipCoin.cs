using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class FlipCoin
    {
        int countHead = 0;
        int countTail = 0;
        float headPercentage;
        float tailPercentage;
        public void Flip()
        {
            Console.WriteLine("Enter the Times you want to FlipCoin");
            float times = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            
            for (int i = 0; i < times; i++)
            {
                double check=random.NextDouble();   
                if (check > 0.5 )
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Head Out Of Total Flips " + countHead);
            Console.WriteLine("Tails Out Of Total Flips " + countTail);
            headPercentage = (countHead / times) * 100;
            Console.WriteLine(headPercentage);
            tailPercentage = (countTail / times) * 100;
            Console.WriteLine(tailPercentage);
        }
    }
}
