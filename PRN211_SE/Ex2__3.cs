using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2__3
    {
        public static void Mains()
        {
            string output = "";
            do
            {
                Console.Write("Please input your computer's age:");
                string input = Console.ReadLine();
                int thisYear = int.Parse(DateTime.Now.ToString("yyyy"));
                if (int.TryParse(input, out int age) && thisYear - age >0)
                {
                    age = thisYear - age;
                    if (age >= 15)
                    {
                        output = "Thay the";
                    }
                    else if (age >= 10 && age < 15)
                    {
                        output = "Bao tri";
                    }
                    else
                    {
                        output = "Khong co de xuat";
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            } while (output == "");
            Console.WriteLine(output);
        }
    }
}
