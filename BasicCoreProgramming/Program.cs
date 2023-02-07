﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. FlipCoin \n2. LeapYear \n3. PowerOf2 \n4. HarmonicNumber \n5. Factor " +
                "\n Exit");

            Console.WriteLine("Enter the Option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Flip();
                    break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
                case 3:
                    PowerOf2 power = new PowerOf2();
                    power.Power();
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Harmonic();
                    break;
                case 5:
                    Factor fact = new Factor();
                    fact.Factors();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
