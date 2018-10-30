using System;
 
namespace CourseApp4
{
    class Program2
    {
        static double a = 1.2;
        static double b = 0.48;

        static void Main(string[] args)
        {

         double xn = 0.7;
         double xk = 2.2;
         double dx = 0.3;
         double[] xx = {0.25, 0.36, 0.56, 0.94, 1.28};
         
         Console.WriteLine ("Задание А");
         
         for( double x=xn; x<xk; x+=dx)
            {
               Console.WriteLine (Fan(x));
                
            }

          Console.WriteLine ("Задание B");

         foreach( double x in xx)
            {
                Console.WriteLine (Fan(x));
            }

        }   

        public static double Fan(double x)
        { 

        double y = (b*b*b + Math.Sin(a*x)*Math.Sin(a*x)) / (Math.Acos(x*b*x) + Math.Exp(-x/2));
         return y;
        }
       
     }

}   

