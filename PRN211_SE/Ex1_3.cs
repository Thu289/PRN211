using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex1_3
    {
        public static void Mains()
        {
            int i, j;
            Console.WriteLine("Shape 1:");
            for (i=0; i<5; i++)
            {
                for (j=0; j<=i; j++)
                {
                    Console.Write("* ");
                    if (j==i)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 2:");
            for (i=5; i>0; i--)
            {
                for (j=1; j<=i; j++)
                {
                    Console.Write("* ");
                    if (j==i)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 3:");
            for (i=5; i>0; i--)
            {
                for (j=1; j<=5; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("* ");

                    }
                    else Console.Write("  ");
                    if (j==5)
                    {
                            Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 4:");
            for (i=1; i<=5; i++)
            {
                for (j=1; j<=5; j++)
                {
                    if (j>=i)
                    {
                        Console.Write("* ");
                    }else Console.Write("  ");
                    if (j==5) Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 5:");
            for (i=0; i<5; i++)
            {
                for (j=-4; j<=4; j++)
                {
                    if (Math.Abs(j)<=i)
                    {
                        Console.Write("* ");
                    }else Console.Write("  ");
                    if (j==4) Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 6:");
            for (i=4; i>=0; i--)
            {
                for (j=-4; j<=4; j++)
                {
                    if (Math.Abs(j) <= i)
                    {
                        Console.Write("* ") ;
                    }else Console.Write("  ");
                    if (j==4) Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 7:");
            for (i=-4; i<=4; i++)
            {
                for (j=-4; j<=4; j++)
                {
                    if (Math.Abs(j) <= Math.Abs(i))
                    {
                        Console.Write("* ");
                    }
                    else Console.Write("  ");
                    if (j==4) Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Shape 8:");
            for (i=0; i<=5; i++)
            {
                for (j=0; j<11; j++)
                {
                    if (i==0 || i==5 || j==0 || j==10)
                    {
                        Console.Write("* ");
                    }else Console.Write("  ");
                    if (j==10) Console.WriteLine();
                }
            }
        }
    }
}
