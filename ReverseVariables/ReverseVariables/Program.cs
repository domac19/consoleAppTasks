using System;

namespace ReverseVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine("Ako zamjenimo mjesta brojevima " + a + " i " + b);

            a = a + b; 
            b = a - b; 
            a = a - b; 
            Console.WriteLine("Dobijemo: " + a + " i " + b);
        }
    }
}
