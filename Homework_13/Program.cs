using System;

namespace Homework_13
{
    class Program
    {
        public static int bb()
        {
            int b=5;
            return b ;
        }


        public static bool bb(int a,int b)
        {
            if((a+b)%2 == 0)
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
            Console.WriteLine("Which is equal to 25/5 ? ");
            Console.WriteLine("25/5 is equal to " + bb());
            Console.Write("The firt number is : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("The second number is : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (bb(a, b))
            {
                Console.WriteLine("The value is an even number");
            }
            else
            {
                Console.WriteLine("The value is an odd number");
            }

        }
    }
}
