using System;

namespace Homework_2
{
    class Program
    {
        public static void cwr(string name)
        {
            Console.WriteLine("Welcome friend " + name + "!");
            Console.WriteLine("Have a nice day");
        }
        static void Main(string[] args)
        {
            Console.Write("Please input a name: ");
            string name = Console.ReadLine();
            cwr(name);
        }
    }
}
