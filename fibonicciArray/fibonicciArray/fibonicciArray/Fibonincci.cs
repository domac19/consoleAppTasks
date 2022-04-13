using System;

namespace fibonicciArray
{
    partial class Program
    {
        public class Fibonincci
        {
            public int GetFibonicciArray()
            {
                Console.Write("Please write number to see fibonicci array of it: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                int entryNumber = Convert.ToInt32(Console.ReadLine());
                
                int a = 0, b = 1, c = 0;

                Console.Write("{0} {1}", a, b);

                for (int i = 2; i < entryNumber; i++)
                {
                    c = a + b;
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                }
                Console.ResetColor();
                
                return entryNumber;                               
            }
        }
    }
}
