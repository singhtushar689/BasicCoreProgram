using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. FlipCoin \n 2. Exit");
            
            Console.WriteLine("Enter the Option");
            int option = Convert.ToInt32(Console.ReadLine()); 
            
            switch(option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
