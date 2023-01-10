using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_5
    {
        public static void Mains(string[] args)
        {
            bool validMonth = true;
            while(validMonth)
            {
                Console.Write("Input month: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int month) && month>0 && month<=12)
                {
                    validMonth = false;
                    if ((new int[] {1,3,5,7,8,10,12}).Contains(month))
                    {
                        Console.WriteLine("This month has 31 days");
                    }else if ((new int[] { 4, 6, 9, 11 }).Contains(month))
                    {
                        Console.WriteLine("This month has 30 days");
                    }else
                    {
                        while (true)
                        {
                            Console.Write("Input year: ");
                            string inputYear = Console.ReadLine();
                            if (int.TryParse(inputYear, out int year) && year >= 0)
                            {
                                if (year%400==0 || (year%4==0 && year % 100 != 0))
                                {
                                    Console.WriteLine("This month has 29 days");
                                }
                                else
                                {
                                    Console.WriteLine("This month has 28 days");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid year, try again!");
                            }
                        }
                    }
                }
            }
        }
    }
}
