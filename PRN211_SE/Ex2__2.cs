using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2__2
    {
        public static void Mains()
        {
            string output = "";
            do
            {
                Console.Write("Please input your point:");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float point) && point >= 0 && point <=10)
                {
                    if (point >= 9)
                    {
                        output = "5 000 000";
                    }
                    else if (point >= 8 && point < 9)
                    {
                        output = "3 000 000";
                    }
                    else if (point >= 7 && point < 8)
                    {
                        output = "1 000 000";
                    }
                    else
                    {
                        output = "Khong co hoc bong";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            } while (output == "");
            Console.WriteLine($"Muc hoc bong: {output}");
        }
    }
}
