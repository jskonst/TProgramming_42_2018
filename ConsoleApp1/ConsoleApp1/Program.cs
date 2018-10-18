﻿using System;

namespace ConsoleApp3
{
    class Program
    {

        static void formula(double x, double a, double b)
        {

            double y = Math.Pow(a * x + b, (1 / 3)) / (Math.Pow(Math.Log10(x), 2));

            Console.WriteLine($"При х = {x} функция y = {Math.Round(y, 3)}");
        }

        static void Main()
        {
            Console.WriteLine("2 вариант");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 1.35;
            double b = 0.98;

            for (double x = 1.14; x <= 4.24; x = x + 0.62)
            {
                formula(x, a, b);
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[] { 0.35, 1.28, 3.51, 5.21, 4.16 };
            foreach (double element in z)
            {
                formula(element, a, b);
            }


            Console.ReadKey();
        }

    }
}