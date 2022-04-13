using System;

namespace factoriels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write one number to see factorial of it.");

            int number = 1;
            var inputNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                number = number * i;
            }
            Console.WriteLine("Factoriel of your number is " + number);
        }
    }
}
