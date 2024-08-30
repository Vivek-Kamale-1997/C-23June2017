using System;
namespace reverse_no
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to find its reverse: ");
            int num =int.Parse(Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
               int d = num % 10;
                rev = (rev * 10) + d;
                num = num / 10;

            }
            Console.WriteLine("Reverse of " + num + " is: " + rev);
            Console.Read();

    }
}
