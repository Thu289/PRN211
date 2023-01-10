using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT1
{
    internal class Ex3
    {
        public static void Mains(string[] args)
        {

        }

        //1. 1-100
        public void ex1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        //2.100-1
        public void ex2()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }

        //3.1-100 && %3==0
        public void ex3()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }

        //4. 99-1 && %7==0
        public void ex4()
        {
            for (int i = 99; i >= 1; i--)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }

        //5. sum 1-50
        public void ex5()
        {
            int s = 0;
            for (int i = 1; i <= 50; i++)
            {
                s += i;
            }
            Console.WriteLine($"Sum 1-50: {s}");
        }

        //6. sum 50-1
        public void ex6()
        {
            int s = 0;
            for (int i = 50; i >= 1; i--)
            {
                s += i;
            }
            Console.WriteLine($"Sum 1-50: {s}");
        }

        //7. sum so chan 50-2 
        public int ex7()
        {
            int s = 0, i = 1, n = 2;
            while (i <= 50)
            {
                s += n;
                n += 2;
                i++;
            }
            return s;
        }

        //8. sum 20 so 5-100
        public int ex8()
        {
            int s = 0, i = 1, n = 5;
            while (i <= 20)
            {
                s += n;
                n += 5;
                i++;
            }
            return s;
        }

        //9. n!
        public int ex9(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //10. Input n, check n nguyen to
        public bool ex10()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            return this.checkSoNguyenTo(n);
        }

        public bool checkSoNguyenTo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //11. Input n, check n hoan hao
        public bool ex11()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 1) return false;
            int s = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    s += i;
                }
            }
            if (s == n) return true;
            return false;
        }

        //12. Output 10 so dau tien day Fibonacci, so thu 13 =??
        public void ex12()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(this.soFibonacci(i) + ", ");
            }
            Console.WriteLine($"So thu 13: {this.soFibonacci(13)}");

        }

        public int soFibonacci(int n)
        {
            if (n == 1 || n == 2) return n;
            return this.soFibonacci(n - 1) + this.soFibonacci(n - 2);
        }

        //13. Input n, n co bn chu so? sum cac chu so trong n, 
        //in ra so lon nhat cua n
        public void ex13()
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int soChuSo = n.ToString().Length;
            Console.WriteLine($"N co {soChuSo} chu so");
            int s = 0;
            int[] chuSo = new int[soChuSo];
            for (int i = 0; i < soChuSo; i++)
            {
                chuSo[i] = n.ToString()[i];
                s += chuSo[i];
            }
            Console.WriteLine($"Tong cac chu so trong N: {s}");
            Console.WriteLine($"Chu so lon nhat cua N: {chuSo.Max()}");
        }

        //14. cho day so 12345678910111213141516.... so thu n =?
        public int ex14()
        {
            string daySo = "1234567891011121314151617181920";
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int soChuSoN = 0;
            for (int i = 1; i < n; i++)
            {
                soChuSoN += this.soChuSo(i);
                if (soChuSoN >= n)
                {
                    int chenhLech = n - soChuSoN + this.soChuSo(i);
                    int x = (int)Math.Ceiling(((chenhLech) / i) - 1 + Math.Pow(10, i-1));
                    if (chenhLech % i == 0)
                    {
                        return x.ToString()[i - 1];
                    }
                    else
                    {
                        int soDu = x % i;
                        return x.ToString()[i - 1 - soDu];
                    }
                    break;
                } 
            }
            return 0;
        }
        public int soChuSo(int n)
        {
            int a = 1;
            int b = 9;
            for (int i=2; i<=n; i++)
            {
                a *= 10;
                b = 9 * b + 9;
            }
            return (b - a + 1) * n;
        }

        //15. input n nguyen duong, phan tich n thanh so ng to
        public List<List<int>> ex15()
        {
            List<List<int>> result = new List<List<int>>();
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for (int a=2; a<n; a++)
            {
                if (n % a == 0)
                {
                    result[i][0] = a;
                    result[i][1] = (string.IsNullOrEmpty(result[i][1].ToString())) ?
                        result[i][1] = 1 : result[i][1]++;
                    n /= a;
                    a--;
                    i++;
                }
            }
            Console.Write(n + "= ");
            for (int j = 0; j < result.Count; j++)
            {
                Console.Write($"({result[j][0]} ^ {result[j][1]} ");
            }
            return result;
        }

        //16. input 0<a<b<100, tim so nguyen to a-b, tim ucln a,b
        public void ex16()
        {
            bool validInput = true;
            while (validInput)
            {
                Console.Write("Input a: ");
                string x = Console.ReadLine();
                Console.Write("Input b: ");
                string y = Console.ReadLine();
                if (int.TryParse(x, out int a)
                    && int.TryParse(y, out int b)
                    && 0<a && a<b && b < 100)
                {
                    validInput = false;
                    Console.WriteLine("So nguyen to: ");
                    int ucln = 1;
                    for (int i = a; i <= b; i++)
                    {
                        if (this.checkSoNguyenTo(i))
                        {
                            Console.WriteLine(i);
                        }
                        if (a % i == 0 && b % i == 0)
                        {
                            ucln = i;
                        }
                    }
                    Console.WriteLine("Uoc chung lon nhat: " + ucln);
                }else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            }
        }
    }
}
