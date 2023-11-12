using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pact3_Ivan;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class ABTests
    {
        [TestMethod]
        public void AMoreB()
        {
            ABNumbers abNumbers = new ABNumbers(2, 1);
            Assert.ThrowsException<ArgumentException>(() => abNumbers.GetResult());
        }

        [TestMethod]
        public void AEqualB1()
        {
            ABNumbers abNumbers = new ABNumbers(7, 7);
            Assert.AreEqual(0, abNumbers.GetResult());
        }

        [TestMethod]
        public void AEqualB2()
        {
            ABNumbers abNumbers = new ABNumbers(14, 14);
            Assert.AreEqual(1, abNumbers.GetResult());
        }

        [TestMethod]
        public void BMoreA()
        {
            ABNumbers abNumbers = new ABNumbers(1, 30);
            Assert.AreEqual(2, abNumbers.GetResult());
        }
    }
}
