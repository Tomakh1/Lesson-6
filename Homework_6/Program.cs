using System;

namespace Homework_6
{
    class Program
    {
        public static void num(ref int a,ref int b)
        {
            int z;
            z = a;
            a = b;
            b = z;
            
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            num(ref a,ref b);
            Console.WriteLine("Now the 1st number is : {0} , and the 2nd number is : {1}",a, b);
        }
    }
}
