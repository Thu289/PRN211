using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT2
{
    internal class Ex2_5
    {

        public static void Mains(string[] args)
        {
            SoNguyenTo soNguyenTo = new SoNguyenTo();
            soNguyenTo.A = 6;
            bool a = soNguyenTo.isSoNguyenTo(soNguyenTo.A);
            Console.WriteLine(a);
            soNguyenTo.A = 2;
            int x = soNguyenTo.timSoNguyenToTiepTheo();
            Console.WriteLine($"so ng to: {x}");
        }

        class SoNguyenTo
        {
            int a;

            public SoNguyenTo() { }

            public SoNguyenTo(int x) 
            {
                if (isSoNguyenTo(x))
                {
                    this.a = x;
                }
                else
                {
                    Console.WriteLine("X ko phai so nguyen to");
                }
                
            }

            public int timSoNguyenToTiepTheo()
            {
                int i = a+1;
                while (true)
                {
                    if (isSoNguyenTo(i))
                    {
                        return i;
                    }
                    else i++;
                }
            }

            public int A
            {
                get { return a; }
                set 
                {
                    if (isSoNguyenTo(value))
                    {
                        a = value;
                    }
                    else
                    {
                        Console.WriteLine("Ko set");
                    }
                }
            }

            public bool isSoNguyenTo(int x)
            {
                if (x <= 0 || x==1)
                {
                    return true;
                }
                for (int i=2; i<= Math.Sqrt(x); i++)
                {
                    if (x%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
