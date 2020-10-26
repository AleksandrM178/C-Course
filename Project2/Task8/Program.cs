using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-100, 100);
            }
            Console.WriteLine();
            Console.Write("Исходный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            int h = n / 2;
            for (int i = 0; i < h; i++)
            {
                int t = a[i];
                if (a.Length % 2 == 0)
                {
                    a[i] = a[h + 1];
                    a[h + 1] = t;
                }
                else
                {
                    a[i] = a[h + i + 1];
                    a[h + i + 1] = t;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}, ");
            }
        }
    }
}
