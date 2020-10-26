using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами");
            Console.WriteLine("Введите количество переменных массива");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-1000, 1000);
            }
            Console.WriteLine();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            int oddIndexSum = 0;
            for (int i = 0; i < a.Length; i++)
                if (i % 2 != 0)
                {
                    oddIndexSum += a[i];
                }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов с нечетными индексами равна: {oddIndexSum} ");
        }
    }
}
