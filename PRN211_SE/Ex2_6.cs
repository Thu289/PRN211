using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_6
    {
        public static void Mains(string[] args)
        {
        }

        //pt bac nhat ax+b=0
        public void ptBacNhat(double a,double b)
        {
            Console.WriteLine($"Phuong trinh {a}x+{b}=0: ");
            if (a == 0)
            {
                if (b== 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else if (b == 0)
            {
                Console.WriteLine("PT co nghiem x=0");
            }else
            {
                Console.WriteLine($"PT co nghiem: x={-b / a}");
            }
        }

        public void ptBacHai(double a,double b, double c) 
        {
            if (a== 0)
            {
                this.ptBacNhat(b,c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                } else if(delta == 0) 
                {
                    Console.WriteLine($"PT co nghiem: x = {-b / (2 * a)}");
                }
                else
                {
                    Console.WriteLine($"PT co nghiem:" +
                        $" x = {(-b+Math.Sqrt(delta))/(2*a)};" +
                        $" x = {(-b - Math.Sqrt(delta)) / (2 * a)}");

                }
            }
        }

        public void ptTrungPhuong(double a,double b,double c)
        {
            if (a == 0)
            {
                if (c > 0)
                {
                    Console.WriteLine("PT vo nghiem");
                }
                else if (b == 0 && c==0)
                {
                    Console.WriteLine("PT co vo so nghiem: ");
                }else
                {
                    Console.WriteLine($"PT co nghiem x = +-{Math.Sqrt(-c/b)}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    if (x < 0)
                    {
                        Console.WriteLine("vo NGHIEM");
                    }else
                    {
                        Console.WriteLine($"PT co 2 nghiem: x = {x}; x= {-x}");
                    }
                }
                else
                {
                    double x = (-b + Math.Sqrt(delta)) / (2 * a);
                    if (x > 0)
                    {
                        Console.WriteLine($"PT co 2 nghiem: x = {x}; x={-x}");
                    }
                    x = (-b - Math.Sqrt(delta)) / (2 * a);
                    if (x > 0)
                    {
                        Console.WriteLine($"PT co 2 nghiem: x = {x}; x={-x}");
                    }
                }               
            }
        }
    }
}
