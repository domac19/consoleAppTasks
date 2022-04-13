using System;

namespace divideBy
{
    partial class Program
    {
        public class DivideBy
        {
            public int GetHighNumberOfDividion()
            {
                Console.WriteLine("Enter one number to see first big number divided by 3");
                int number = Convert.ToInt32(Console.ReadLine());

                do
                {
                    number++;
                } while (number % 3 != 0);

                return number;
            }
        }
    }
}
