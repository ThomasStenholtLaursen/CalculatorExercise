using NUnit.Framework;
using Calculator.Library;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private Library.Calculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Library.Calculator();
        }


        [TestCase(10, 5, 15)]
        [TestCase(14, 7, 21)]
        [TestCase(6, 9, 15)]
        [TestCase(15.6, 8.9, 24.5)]
        [TestCase(1000, -100, 900)]
        [TestCase(25.5, -10.4, 15.1)]
        [Test]
        public void TestOfAdd_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Add(a, b);
            Assert.That(test, Is.EqualTo(result));
        }

        [TestCase(10, 5, 5)]
        [TestCase(14, 7, 7)]
        [TestCase(6, 9, -3)]
        [TestCase(15.6, 8.9, 6.7)]
        [Test]
        public void TestOfSubtract_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Subtract(a, b);
            Assert.That(test, Is.EqualTo(result).Within(1E-14));
        }

        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 25)]
        [TestCase(5, -1, 0.2)]
        [Test]
        public void TestOfPower_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Power(a, b);
            Assert.That(test, Is.EqualTo(result));
        }

        [TestCase(2, 2, 16)]
        [TestCase(5, 2, 33554432)]
        [TestCase(2, 4, 4294967296)]
        [TestCase(-1, 2, 2)]
        [Test]
        public void TestOfPower_MulitpleNumbes_OverloadedPower(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Power(a, b);
            var test2 = _uut.Power(b);
            Assert.That(test2, Is.EqualTo(result));
        }
    }
}