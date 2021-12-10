using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSampleProject
{
    public class Factorial
    {
        int number;
        public Factorial()
        { }
        public Factorial(int n)
        {
            number = n;
        }
        public long GetFactorial()
        {
            return GetFactorial(number);
        }
        public long GetFactorial(int n)
        {
            if (n <= 0) return 1;
            else
                return n * this.GetFactorial(n - 1);
        }
    }
}
