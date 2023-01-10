using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex1_6
    {
        public static void Mains()
        {
            Console.Write("Nhap canh 1: ");
            float canh1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            float canh2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Chu vi hinh vuong: {canh1+canh2+Math.Sqrt(canh1*canh1+canh2*canh2)}");
            Console.WriteLine($"Dien tich hinh vuong: {canh1*canh2*0.5}");
        }
    }
}
