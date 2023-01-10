using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_4
    {
        public static void Mains(string[] args)
        {
            bool validInput = true;
            while(validInput){
                Console.Write("Input a char: ");
                string input = Console.ReadLine();
                if (input.Length > 1)
                {
                    Console.WriteLine("Invalid input, try again!");
                }
                else
                {
                    validInput = false;
                    if ((new string[] { "u", "e", "o", "a", "i" }).Contains(input))
                    {
                        Console.WriteLine("Char is vowel");
                    }else if (Char.IsLetter(input[0]))
                    {
                        Console.WriteLine("Char is consonant");
                    }else
                    {
                        Console.WriteLine("Char is digit");
                    }
                }
            }           
        }
    }
}
