using System;

namespace SoftwareTestingAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            Console.WriteLine("Enter n:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n + "! = " + factorial.GetFactorial(n));
        }
    }
}
