//5] to check if number is prime or not
//note:prime no is divisible by 1 and the number itself !!
using System;
namespace tyitA
{
    class 3.prime_no
    {
        public static void Main()
        {
            Console.Write("Enter a number to check if prime or not : ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count = count + 1;
                }
                if (count == 0)
                {
                    Console.WriteLine("Number " + num + " is prime");
                }
                else
                {
                    Console.writeLine("Number " + num + " is not prime");
                }
                Console.Read();
            }
        }
    }
 