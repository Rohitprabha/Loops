using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            long factorial = number;
            while (number > 1)
                factorial *= --number;
            System.Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
