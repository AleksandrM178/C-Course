using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс наибольшего элемента массива");
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
            int index = 0;
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                    a[i] = i;
                    index = a[i];
                }
            Console.WriteLine();
            Console.WriteLine($"Индекс наибольшего элемента массива: {index}");
        }
    }
}
