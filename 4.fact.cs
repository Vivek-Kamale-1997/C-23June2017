// 4]factorial of a number
using System;
namespace tyitA
{
    class fact_no
    {
        public static void Main()
        {
            Console.Write("Enter a number whose factorial is required : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + " is : " + fact);
            Console.Read();
        }
    }
}
