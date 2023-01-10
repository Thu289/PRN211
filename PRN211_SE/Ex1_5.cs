using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex1_5
    {
        public static void Mains()
        {
            Console.Write("NHap diem thi lan 1: ");
            int diemLan1 = Int32.Parse(Console.ReadLine());
            Console.Write("NHap diem thi online: ");
            int diemOnl = Int32.Parse(Console.ReadLine());
            Console.Write("NHap diem thi cuoi ky: ");
            int diemCuoiKy = Int32.Parse(Console.ReadLine());
            Console.Write($"Diem thi cuoi ky: {0.25*(diemLan1+diemOnl)+0.5*diemCuoiKy}");
        }
    }
}
