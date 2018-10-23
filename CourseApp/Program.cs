using System;

namespace CourseApp
{
    /**
    27 Variant
     */
    public class Program
    {
        public static double myCalc(double a, double b, double x){
            var chisl = Math.Pow(a, 1.0/3.0) + Math.Pow(Math.Tan(b*x),4.5);
            var znam = Math.Pow(b, 1/5.0) + 1/Math.Pow(Math.Tan(a*x), 2.7);
            return chisl/znam;
        }

        static void Main(string[] args)
        {
            var a = 2;
            var b = 4.1;
            var xn = 0.77;
            var xk = 1.77;
            var dx = 0.2;

            double[] xs = {1.24, 1.38, 2.38, 3.21, 0.68};
            
        }
    }
}
