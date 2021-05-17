using System;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, res = 0, i = 1;
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                res = number * i;
                Console.WriteLine("{0} X {1} = {2}", number, i, res);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
