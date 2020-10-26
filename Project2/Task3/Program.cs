﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс минимального элемента массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int index = 0;
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
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min >= a[i])
                {
                    min = a[i];
                    a[i] = i;
                    index = a[i];
                }
            Console.WriteLine();
            Console.WriteLine($"Индекс наименьшего элемента массива: {index}");
        }
    }
}
