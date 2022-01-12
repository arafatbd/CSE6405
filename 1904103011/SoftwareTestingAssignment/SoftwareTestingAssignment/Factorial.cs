using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareTestingAssignment
{
    public class Factorial
    {
        public long GetFactorial(int n)
        {
            long fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
