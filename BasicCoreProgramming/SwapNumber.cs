using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class SwapNumber
    {
        public void Swap()
        {
            Console.WriteLine("Enter the First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("FirstNumber after Swapping is " + firstNumber);
            Console.WriteLine("SecondNumber after Swapping is " + secondNumber);
        }
    }
}
