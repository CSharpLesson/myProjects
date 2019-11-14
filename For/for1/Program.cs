using System;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j = 10;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            {
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
