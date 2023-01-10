using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_1
    {
        public static void Mains()
        {
            bool validInput = false;
            do
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float number))
                {
                    validInput = true;
                    if (number % 1 ==0)
                    {
                        Console.WriteLine("N la so nguyen!");
                        number = (int)number;
                        if (number % 2 == 0)
                        {
                            Console.WriteLine("N la so chan!");
                            if (number > 0)
                            {
                                Console.WriteLine("N la so chan duong");
                            }
                        }
                        else
                        {
                            Console.WriteLine("N la so le!");
                            if (number < 0)
                            {
                                Console.WriteLine("N la so le am");
                            }
                        }
                        if (Math.Sqrt(number) %1 == 0)
                        {
                            Console.WriteLine("N la so chinh phuong");
                        }
                        else
                        {
                            Console.WriteLine("N ko phai so chinh phuong");
                        }
                        string n = number.ToString();
                        double result = 0;
                        for (int i=0; i<n.Length; i++)
                        {
                            result += Math.Pow((int)n[i], 3);
                        }
                        if ((int)result == number)
                        {
                            Console.WriteLine("N la so dac biet");
                        }else
                        {
                            Console.WriteLine("N ko phai so dac biet");
                        }
                    }
                    else
                    {
                        Console.WriteLine("N ko phai so nguyen");
                    }
                }

            } while (!validInput);
        }
    }
}
