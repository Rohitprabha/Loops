using System;

namespace Nested_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, n = 1;
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + "   ");
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
