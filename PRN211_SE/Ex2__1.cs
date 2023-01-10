using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2__1
    {
        public static void Mains()
        {
            string output = "";
            do
            {
                Console.Write("Please input your hour working:");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float hour) && hour >= 0)
                {
                    if (hour >= 200)
                    {
                        output = "20%";
                    }
                    else if (hour >= 100 && hour < 200)
                    {
                        output = "10%";
                    }
                    else
                    {
                        output = "0";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            } while (output == "");
            Console.WriteLine($"Muc thuong: {output} luong");
        }
    }
}
