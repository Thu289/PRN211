using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_2
    {
        public static void Mains()
        {
            int a = 5, b = 10;
            Console.WriteLine($"a= {a}, b = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a= {a}, b = {b}");
        }
    }
}
