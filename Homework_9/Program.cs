using System;

namespace Homework_9
{
    class Program
    {
        public static bool prime(int a)
        {
            int q = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                     q++;
                }
            }
            if (q == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (prime(a))
            {
                Console.WriteLine(a + " is a prime number");
            }
            else
            {
                Console.WriteLine(a + " is not a prime number");
            }
        }
    }
}
