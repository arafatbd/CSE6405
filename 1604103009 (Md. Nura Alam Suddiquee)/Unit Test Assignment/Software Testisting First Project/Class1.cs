using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Testisting_First_Project
{
    public class Factorial
    {
        public long CalculateFactorial(int n)
        {
            long fact = 1;
            if (n < 0)
            {
                return fact;
            }
            else
            { 
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
            }
            return fact;
        }
    }
}
