using NUnit.Framework;
using Software_Testisting_First_Project;

namespace NUnitTestForFactorial
{
    public class Tests
    {
        public Factorial fact;
        [SetUp]
        public void Setup()
        {
            fact = new Factorial();
        }

        [Test]
        public void ZeroFactorialreturns1()
        {
            Assert.AreEqual(1,fact.CalculateFactorial(0));
        }

        [Test]
        public void NegativeFactorialreturns1()
        {
            Assert.AreEqual(1, fact.CalculateFactorial(-2));
        }

        [Test]
        public void FourFactorialreturns24()
        {
            Assert.AreEqual(24, fact.CalculateFactorial(4));
        }

        [Test]
        public void Tenactorialreturns3628800()
        {
            Assert.AreEqual(3628800, fact.CalculateFactorial(10));
        }
    }
}