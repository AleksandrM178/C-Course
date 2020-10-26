using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделать реверс массива (массив в обратном направлении)");
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
            int t;
            Console.Write("Реверс массива:");
            for (int i = 0; i < a.Length; i++)
            {

                t = a[i];        
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;


                Console.Write(a[i] + " ");
            }
        }
    }
}
