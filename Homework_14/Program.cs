using System;

namespace Homework_14
{
    class Program
    {
        public static int sum(int a)
        {
            int b = a;
            return b;
        }
        public static int str(string st)
        {
            int i;
            for(i = 0; i < st.Length; i++)
            {
                int q = 0;
                if(st[i]== 'a')
                {
                    
                    return i;
                }
                else
                {
                    return i-1;
                }
            }

          
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the string ");
            string st = Console.ReadLine();
            int[] array = new int[2] { sum(a), str(st) };
            Console.WriteLine(array);
            
        }
    }
}
