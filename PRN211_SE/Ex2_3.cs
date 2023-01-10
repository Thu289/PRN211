using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE
{
    internal class Ex2_3
    {
        public static void Mains() {
            int a = 3, b = 5, c = 2, d = 4;
            int[] arr = new int[4];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;
            arr[3] = d;
            Console.WriteLine($"Max: {arr.Max()}");
            Console.WriteLine($"Min: {arr.Min()}");
            Array.Sort(arr);
            Console.Write("Array in asc: ");
            foreach (int i in arr) Console.Write(i+" ");
            Console.Write("Array in desc: ");
            Array.Reverse(arr);
            foreach (int i in arr) Console.Write(i+" ");
        }

    }
}
