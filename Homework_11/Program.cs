using System;

namespace Homework_11
{
    class Program
    {
        public static int fact(int a)
        {
            int mul = 1;
            for(int i = 1; i <= a; i++)
            {
                mul *= i;
            }
            return mul;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factorial of " + a + "! is " + fact(a));

        }
    }
}
