using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of" + n + "! is " + fact(n));
            Console.ReadKey();
        }

        static int fact(int n)
        {
            if (n <= 0) return 1;
            else
                return n * fact(n-1);
        }
    }
}
