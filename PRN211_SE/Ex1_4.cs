using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex1_4
    {
        public static void Mains()
        {
            int n = Int32.Parse(Console.ReadLine());
            string m = Convert.ToString(n);
            for (int i=0; i< m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
        }
    }
}
