using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT2
{
    internal class Ex1
    {
        public static void Main(string[] args)
        {
            int option = 0;
            int n=0;
            bool loop = true;
            int[] arr = (n == 0) ? new int[3] : new int[n];
            while ((option <= 0 || option >13) || loop)
            {
                Console.WriteLine("1. Nhap mot so nguyen N (0<N<50)");
                Console.WriteLine("2. Nhap 1 mang gom N so thuc");
                Console.WriteLine("3. Tim max trong mang");
                Console.WriteLine("4. Tim min trong mang");
                Console.WriteLine("5. Tim so duong chan max trong mang");
                Console.WriteLine("6. Tim so am le min trong mang");
                Console.WriteLine("7. Tim cac so chinh phuong trong bang");
                Console.WriteLine("8. Tinh sum mang");
                Console.WriteLine("9. Tinh tbc mang");
                Console.WriteLine("10. Tim phan tu > tbc");
                Console.WriteLine("11. Sap xep mang tang dan");
                Console.WriteLine("12. Sap xep mang giam dan");
                Console.WriteLine("13. In ra tbc cac >=0");
                Console.Write("Select action you want: ");
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option != 1 && n==0)
                    {
                        Console.WriteLine("Let's input n before!");
                    }
                    else
                    {
                        switch (option)
                        {
                            case 1:
                                InputN(ref n);
                                break;
                            case 2:
                                InputArr(arr);
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.WriteLine($"So lon nhat trong mang: {arr.Max()}");
                                break;
                            case 4:
                                Console.WriteLine($"So nho nhat trong mang: {arr.Min()}");
                                break;
                            case 5:
                                DuongChanMax(arr);
                                break;
                            case 6:
                                AmLeMin(arr);
                                break;
                            case 7:
                                SoChinhPhuong(arr);
                                break;
                            case 8:
                                TongMang(arr);
                                break;
                            case 9:
                                TBC(arr);
                                break;
                            case 10:
                                LonHonTBC(arr);
                                break;
                            case 11:
                                SortTangDan(arr);
                                break;
                            case 12:
                                SortGiamDan(arr);
                                break;
                            case 13:
                                TBCKoAm(arr);
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                    Console.WriteLine();
                    option = 0;
                }
            }
        }

        public static void InputN(ref int n)
        {
            while(n<=0 || n>=50)
            {
                Console.Write("Input n: ");
                if (int.TryParse(Console.ReadLine(), out n) && n>0 && n<50)
                {
                    break;
                }
            }
        }

        public static void InputArr(params int[] arr)
        {
            bool validInput;
            for (int i=0; i<arr.Length; i++)
            {
                validInput = false;
                do
                {
                    Console.Write($"Input array[{i}]: ");
                    if (int.TryParse(Console.ReadLine(), out int item))
                    {
                        arr[i] = item;
                        validInput = true;
                    }
                    else Console.WriteLine("Invalid input, try again!" + arr[i]);
                } while (!validInput);
            }
        }

        public static void DuongChanMax(params int[] arr)
        {
            int max = arr.Min();
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max && arr[i]>0 && arr[i]%2==0) max = arr[i];
            }
            if (max > arr.Min()) Console.WriteLine("So duong chan lon nhat: " + max);
            else Console.WriteLine("Mang ko co so duong chan lon nhat");
        }

        public static void AmLeMin(params int[] arr)
        {
            int min = arr.Max();
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < min && arr[i] <0 && arr[i]%2==1) min = arr[i];
            }
            if (min < arr.Max()) Console.WriteLine("So am le nho nhat: " + min);
            else Console.WriteLine("MAng ko co so am le nho nhat");
        }

        public static void SoChinhPhuong(params int[] arr)
        {
            Console.WriteLine("So chinh phuong: ");
            for (int i=0; i<arr.Length; i++)
            {
                if (Math.Sqrt(arr[i]) % 1 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public static int TongMang(params int[] arr)
        {
            int s = 0;
            for (int i=0; i<arr.Length; i++)
            {
                s += arr[i];
            }
            Console.WriteLine("Tong mang: " + s);
            return s;
        }

        public static double TBC(params int[] arr)
        {
            double tbc = TongMang(arr) / arr.Length;
            Console.WriteLine("Trung binh cong: "+(tbc));
            return tbc;
        }

        public static void LonHonTBC(params int[] arr)
        {
            double tbc = TBC(arr);
            Console.WriteLine("So lon hon tbc:");
            for (int i=0; i< arr.Length; i++)
            {
                if (arr[i] > tbc)
                {
                    Console.WriteLine(arr[i]); 
                }
            }
        }

        public static void SortTangDan(params int[] arr)
        {
            Console.WriteLine("Mang tang dan: ");
            Array.Sort(arr);
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void SortGiamDan(params int[] arr)
        {
            Console.WriteLine("Mang giam dan: ");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void TBCKoAm(params int[] arr)
        {
            int s = 0, size = 0;
            for (int i=0; i<arr.Length;i++)
            {
                if (arr[i] >=0)
                {
                    s += (int)arr[i];
                    size++;
                }
            }
            Console.WriteLine("TBC cac so ko am: " + (s / size));
        }
    }
}
