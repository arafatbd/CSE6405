using factorialConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for fact
        ///</summary>
        [TestMethod()]
        [DeploymentItem("factorialConsole.exe")]
        public void factTest()
        {
            int n = 9; // TODO: Initialize to an appropriate value
            int expected = 362880; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program_Accessor.fact(n);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        [DeploymentItem("factorialConsole.exe")]
        public void factTestforZero()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program_Accessor.fact(n);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [DeploymentItem("factorialConsole.exe")]
        public void factTestforNegative()
        {
            int n = -45; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program_Accessor.fact(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("factorialConsole.exe")]
        public void factTestforFail()
        {
            int n = 5; // TODO: Initialize to an appropriate value
            int expected = 100; // TODO: Initialize to an appropriate value
            int actual;
            actual = Program_Accessor.fact(n);
            Assert.AreEqual(expected, actual);
        }





    }
}
