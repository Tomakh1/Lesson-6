using System;

namespace Homework_10
{
    class Program
    {
        public static int dig(string a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += Convert.ToInt32(a.Substring(i, 1));
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string a = Console.ReadLine();
            Console.WriteLine("The sum of digits of the number " + a + " is " + dig(a));
        }
    }
}
