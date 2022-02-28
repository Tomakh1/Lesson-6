using System;

namespace Homework_7
{
    class Program
    {
        public static double pow(double a,double b)
        {
            return Math.Pow(a, b);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Input Base number: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Exponent: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So, the number " + a + " ^ " + b + " = " + pow(a, b));
        }
    }
}
