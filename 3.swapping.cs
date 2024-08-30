//3] Swapping of two numbers
using System;
namespace tyitA
{
    class swao_two_no
    {
        public static void Main()
        {
            Console.Write("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            Console.WriteLine("Before swapping: ");
            Console.WriteLine("a=" + a + "  b=" + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping: ");
            Console.WriteLine("a=" + a + "  b=" + b);
            Console.Read();
        }
    }
}