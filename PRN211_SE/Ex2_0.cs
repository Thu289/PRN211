using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_0
    {
        public static void Mains()
        {
            string output = "";
            do
            {
                Console.Write("Please input your average point:");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float point) && point >= 0 && point<=10)
                {
                    if (point >= 8)
                    {
                        output = "Gioi";
                    }
                    else if (point >= 6 && point < 8)
                    {
                        output = "Kha";
                    }
                    else if (point >= 5 && point < 6)
                    {
                        output = "Trung binh";
                    }
                    else
                    {
                        output = "Kem";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            } while (output == "");
            Console.WriteLine($"Hoc luc: {output}");
        }
    }
}
