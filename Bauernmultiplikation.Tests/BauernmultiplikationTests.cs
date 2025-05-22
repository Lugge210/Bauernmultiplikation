using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bauernmultiplikation;

namespace Bauernmultiplikation.Tests
{
    [TestClass]
    public class BauernmultiplikationTests
    {
        [TestMethod]
        public void Mul_PositiveNumbers_ReturnsProduct()
        {
            Assert.AreEqual(91, Multiplikator.Mul(13, 7));
            Assert.AreEqual(150, Multiplikator.Mul(25, 6));
        }

        [TestMethod]
        public void Mul_NegativeNumbers_ReturnsProduct()
        {
            Assert.AreEqual(-12, Multiplikator.Mul(-3, 4));
            Assert.AreEqual(-48, Multiplikator.Mul(4, -12));
            Assert.AreEqual(21, Multiplikator.Mul(-7, -3));
        }

        [TestMethod]
        public void Mul_Zero_ReturnsZero()
        {
            Assert.AreEqual(0, Multiplikator.Mul(0, 5));
            Assert.AreEqual(0, Multiplikator.Mul(5, 0));
            Assert.AreEqual(0, Multiplikator.Mul(0, 0));
        }
    }
}