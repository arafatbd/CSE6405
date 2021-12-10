using NUnit.Framework;
using UnitTestSampleProject;

namespace NUnitTestProject
{
    public class Tests
    {
        public Factorial factorial;
        public Factorial factorialWithConstructor;
        [SetUp]
        public void Setup()
        {
            factorial = new Factorial();
            factorialWithConstructor = new Factorial(5); 
        }

        [Test]
        public void NegativeFactorialShouldReturnOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(-5));
            Assert.AreEqual(1, factorial.GetFactorial(-1));
            Assert.AreEqual(1, factorial.GetFactorial(-100));

        }
        [Test]
        public void FactorialOfZeroShouldEqualOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(0));
        }
        [Test]
        public void FactorialOfOneIsEqualOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(1));
        }
        [Test]
        public void FactorialOfThreeEqualSix()
        {
            Assert.AreEqual(6, factorial.GetFactorial(3));
        }
        [Test]
        public void FactorialOfFiveEqual120()
        {
            Assert.AreEqual(120, factorial.GetFactorial(5));
        }
    }
}