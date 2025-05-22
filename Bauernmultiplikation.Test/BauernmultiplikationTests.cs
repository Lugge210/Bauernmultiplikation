using Bauernmultiplikation;

namespace Bauernmultiplikation.Tests
{
    public class BauernmultiplikationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mul_PositiveNumbers_ReturnsProduct()
        {
            Assert.That(Multiplikator.Mul(13, 7), Is.EqualTo(91));
            Assert.That(Multiplikator.Mul(25, 6), Is.EqualTo(150));
        }

        [Test]
        public void Mul_NegativeNumbers_ReturnsProduct()
        {
            Assert.That(Multiplikator.Mul(-3, 4), Is.EqualTo(-12));
            Assert.That(Multiplikator.Mul(4, -12), Is.EqualTo(-48));
            Assert.That(Multiplikator.Mul(-7, -3), Is.EqualTo(21));
        }

        [Test]
        public void Mul_Zero_ReturnsZero()
        {
            Assert.That(Multiplikator.Mul(0, 5), Is.EqualTo(0));
            Assert.That(Multiplikator.Mul(5, 0), Is.EqualTo(0));
            Assert.That(Multiplikator.Mul(0, 0), Is.EqualTo(0));
        }
    }
}