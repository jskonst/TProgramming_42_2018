using System;

namespace CourseApp
{
    public class Program
    {
        
        public static double formula(double x, double a, double b)
        {

            return(Math.Pow(a * x + b, (1 / 3)) / (Math.Pow(Math.Log10(x), 2)));
                  
        }

        static void Main()
        {
            Console.WriteLine("2 вариант");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 1.35;
            double b = 0.98;
            double xn = 1.14;
            double xk = 4.24;
            double dx = 0.62;


            for (double x=xn; x <= xk; x = x + dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(formula(x, a, b), 3)}");
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[] { 0.35, 1.28, 3.51, 5.21, 4.16 };
            foreach (double element in z)
            {
                Console.WriteLine($" X={element} y={Math.Round(formula(element, a, b), 3)} ");
            }


            Console.ReadKey();
        }

    }
}