//prog to add two  numbers
using System;
namespace tyitA
{
    class add_two_no
    {
        public static void Main()
        {
            Console.Write("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum= " + (a + b));
            Console.Read();
        }
    }
}