using System;

namespace calculateBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodaj dva velika broja i pogledaj zbroj!");
            ulong firstBigNumber = (UInt64)Convert.ToInt64(Console.ReadLine());
            ulong secondBigNumber = (UInt64)Convert.ToInt64(Console.ReadLine());

            var calculate = firstBigNumber + secondBigNumber;

            Console.WriteLine((UInt64)calculate);
        }
    }
}
