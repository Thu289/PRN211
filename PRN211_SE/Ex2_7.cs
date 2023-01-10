using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT1
{
    internal class Ex2_7
    {
        public static void Mains(string[] args)
        {
            double[] canh=new double[3];
            Console.Write("Nhap canh 1:");
            canh[0]=double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 2:");
            canh[1] = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 3:");
            canh[2] = double.Parse(Console.ReadLine());
            Array.Sort(canh);
            if ((canh[0] < canh[1] + canh[2]) &&
                (canh[1] < canh[0] + canh[2]) &&
                (canh[2] < canh[0] + canh[1]))
            {
                Console.WriteLine("Day la 1 tam giac");
                if (canh[0] == canh[1] || canh[1] == canh[2] || canh[0] == canh[2]) 
                {
                    Console.WriteLine("Day la tam giac can");
                    if (canh[0] == canh[1] && canh[1] == canh[2])
                    {
                        Console.WriteLine("Day la tam giac deu");
                    }
                    else
                    {
                        Console.WriteLine("Day ko phai tam giac deu");
                    }
                }
                else
                {
                    Console.WriteLine("Day ko phai tam giac can");
                }
                if (Math.Pow(canh[2],2) == Math.Pow(canh[0],2) + Math.Pow(canh[1], 2))
                {
                    Console.WriteLine("Day la tam giac vuong");
                    if (canh[0] == canh[1])
                    {
                        Console.WriteLine("Day la tam giac vuong can");
                    }else
                    {
                        Console.WriteLine("Day ko phai tam giac vuong can");
                    }
                }
                else
                {
                    Console.WriteLine("Day ko phai tam giac vuong");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac");
            }
        }
    }
}
