using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class VowelOrConsonant
    {
        public void Vowel()
        {
            Console.WriteLine("Enter the Character");
            char alpha = Convert.ToChar(Console.ReadLine());

            if(alpha =='a'|| alpha == 'e'|| alpha =='i' || alpha=='o'||alpha =='u' ||
                alpha =='A' || alpha == 'E'|| alpha == 'I' || alpha == 'O' || alpha == 'U')
            {
                Console.WriteLine("It is an Vowel");
            }
            else
                Console.WriteLine("It is Consonant");
        }
    }
}
