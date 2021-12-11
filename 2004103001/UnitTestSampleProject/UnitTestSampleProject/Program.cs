using System;

namespace UnitTestSampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x + "! = " + factorial.GetFactorial(x));
        }
    }
}
