using System;

namespace Homework_5
{
    class Program
    {
        public static int sum(int[] array)
        {
            int g=0;
            for (int i = 0; i < array.Length; i++)
            {
                g += array[i];
            }
            
            return g;
        }

        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Input 5 elements in the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element -{0} : " ,i );
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The sum of the elements of the array is " + sum(array));
        }
    }
}
