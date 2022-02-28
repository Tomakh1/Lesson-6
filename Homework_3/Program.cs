using System;

namespace Homework_3
{
    class Program
    {
        public static int sum(int a,int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("The sum of two numbers is: " + sum(a, b));
        }
    }
}
