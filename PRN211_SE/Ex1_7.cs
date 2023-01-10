using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex1_7
    {
        public static void Mains()
        {
            Console.Write("Nhap canh 1: ");
            double canh1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            double canh2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 3: ");
            double canh3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Chu vi hinh vuong: {canh1 + canh2 + canh3}");
            double nuaChuVi = 0.5 * (canh1 + canh2 + canh3);
            Console.WriteLine($"Dien tich hinh vuong:" +
                $" {Math.Sqrt(nuaChuVi*(nuaChuVi-canh1)*(nuaChuVi-canh2)*(nuaChuVi-canh3))}");
        }
    }
}
