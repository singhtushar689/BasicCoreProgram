using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LargestNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter the first Number");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third Number");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            if ((firstNum.CompareTo(secondNum) > 0) && (firstNum.CompareTo(thirdNum) > 0))
                Console.WriteLine("The Largest Number is {0}", firstNum);
            else if ((secondNum.CompareTo(firstNum) > 0) && (secondNum.CompareTo(thirdNum) > 0))
                Console.WriteLine("The Largest Number is {0}", secondNum);
            else
                Console.WriteLine("The Largest Number is {0}", thirdNum);


        }
    }
}
