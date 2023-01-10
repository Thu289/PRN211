namespace PRN211_SE
{
    internal class Program
    { 
        static void Mains(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //mang 1 chieu
            int[] a = new int[5];
            int[] b;
            b = new int[5];
            float[] c = new float[] { 1, 2, 3, 4, 5 };
            double[] d = { 6, 7, 8, 9 };
            //nhap lieu
            Console.WriteLine("Input data for a way:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //
            float f = 2345.53f;
            Console.WriteLine($"{f,5:0}");
            //tu khoa: out, ref, params
        }

        class Animal
        {
            int id;
            string name;
            float weight;
            bool gender;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        }
    }
}