using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2__4
    {
        public static void Mains()
        {
            string output = "";
            do
            {
                Console.Write("Please input your age:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age))
                {
                    if (age > 0 && age <= 2)
                    {
                        output = "Tre so sinh";
                    }
                    else if (age > 2 && age <= 10)
                    {
                        output = "nhi dong";
                    }
                    else if (age > 10 && age <= 17)
                    {
                        output = "vi thanh nien";
                    }
                    else if (age > 17 && age <= 39)
                    {
                        output = "thanh nien";
                    }
                    else if (age > 39 && age <= 50)
                    {
                        output = "trung nien";
                    }
                    else
                    {
                        output = "cao nien";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            } while (output == "");  
            Console.WriteLine($"Dang o do tuoi {output}");
        }
    }
}
