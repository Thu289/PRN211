using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT2
{
    internal class Ex2_8
    {
        class Fraction
        {
            public int tuSo;
            public int mauSo;

            public Fraction() { }

            public Fraction(int tuSo, int mauSo)
            {
                this.tuSo = tuSo;
                this.mauSo = mauSo;
            }

            public int TuSo
            {
                get { return tuSo; }
                set { tuSo = value; }

            }

            public int MauSo
            {
                get { return mauSo; }
                set { mauSo = value; }
            }

            public void nhapPhanSo()
            {
                bool invalidInput = false;
                while(!invalidInput)
                {
                    Console.Write("Input tu so: ");
                    if (int.TryParse(Console.ReadLine(), out tuSo) )
                    {
                        Console.Write("Input Mau so: ");
                        if (int.TryParse(Console.ReadLine(), out mauSo) && mauSo !=0 )
                        {
                            invalidInput= true;
                        }
                    }
                    if (!invalidInput)
                    {
                        Console.WriteLine("Invalid input, try again!");
                    }
                }
            }

            public void inPhanSo()
            {
                if (tuSo == mauSo)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    rutGonPhanSo();
                    Console.WriteLine($"Tu so: {tuSo}, mauso: {mauSo}");
                }
            }

            public void rutGonPhanSo()
            {
                bool done = false;
                int soBe;
                while (!done)
                {
                    if (tuSo > mauSo) soBe = mauSo; else soBe = tuSo;
                    for (int i = 2; i <= soBe; i++)
                    {
                        if (tuSo % i == 0 && mauSo % i == 0)
                        {
                            tuSo /= i;
                            mauSo /= i;
                            break;
                        }
                        if (i== soBe)
                        {
                            done= true;
                        }
                    }
                }
            }

            public void add (int tuSo1, int mauSo1)
            {
                rutGonPhanSo();
                tuSo = tuSo * mauSo1 + tuSo1 * mauSo;
                mauSo*=mauSo1;
                rutGonPhanSo();
            }

            public void sub(int tuSo1, int mauSo1)
            {
                rutGonPhanSo();
                tuSo = tuSo * mauSo1 - tuSo1 * mauSo;
                mauSo *= mauSo1;
                rutGonPhanSo();
            }

            public void mul(int tuSo1, int mauSo1)
            {
                rutGonPhanSo();
                tuSo *= tuSo1;
                mauSo *= mauSo1;
                rutGonPhanSo();
            }

            public void div(int tuSo1, int mauSo1)
            {
                rutGonPhanSo();
                tuSo *= mauSo1;
                mauSo *= tuSo1;
                rutGonPhanSo();
            }
        }
    }
}
