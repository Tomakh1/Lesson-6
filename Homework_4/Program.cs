using System;

namespace Homework_4
{
    class Program
    {
        public static int space(string a)
        {
            int q=0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==' ')
                {
                    q++;
                }
            }
            
            return q;
        }
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string a = Console.ReadLine();
            Console.WriteLine(a + "contains " + space(a) + " spaces");
        }
    }
}
