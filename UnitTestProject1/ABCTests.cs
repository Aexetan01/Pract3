using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pact3_Ivan;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ABCTests
    {
        [TestMethod]
        public void Less15Less15Less15()
        {
            ABCNumbers abcNumbers = new ABCNumbers(10, 12, 14);
            Assert.AreEqual(12, abcNumbers.GetResult());
        }

        [TestMethod]
        public void Less15Less15More15()
        {
            ABCNumbers abcNumbers = new ABCNumbers(1, 11, 21);
            Assert.AreEqual(11, abcNumbers.GetResult());
        }

        [TestMethod]
        public void Less15More15More15()
        {
            ABCNumbers abcNumbers = new ABCNumbers(10, 29, 21);
            Assert.AreEqual(20, abcNumbers.GetResult());
        }

        [TestMethod]
        public void More15More15More15()
        {
            ABCNumbers abcNumbers = new ABCNumbers(20, 29, 21);
            Assert.AreEqual(70, abcNumbers.GetResult());
        }
    }
}
