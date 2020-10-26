using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти наибольший элемент массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-100, 100);
            }
            Console.WriteLine();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                }
            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент массива: {max}");
        }
    }
}
