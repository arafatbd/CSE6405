using System;

namespace Software_Testisting_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            Factorial fact = new Factorial();
            Console.Write($"Factorial of {number}  is: {fact.CalculateFactorial(number)}");

            Console.ReadLine();
        }
    }
}
