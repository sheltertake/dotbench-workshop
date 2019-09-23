using System;

namespace ConsoleAppCpu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPrime(2147483647);
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i <= n - 1; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
