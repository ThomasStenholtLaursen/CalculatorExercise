using System;
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

        #region Add Test
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
        #endregion

        #region Subtract Test
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
        #endregion

        #region Multiply Test
        [TestCase(10, 5, 50)]
        [TestCase(14, 3, 42)]
        [TestCase(6, 9, 54)]
        [TestCase(15.6, 8.9, 138.84)]
        [Test]
        public void TestOfMultiply_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Multiply(a, b);
            Assert.That(test, Is.EqualTo(result).Within(1E-14));
        }
        #endregion

        #region Power Test
        [TestCase(2, 2, 4)]
        [TestCase(5, 2, 25)]
        [TestCase(5, -1, 0.2)]
        [Test]
        public void TestOfPower_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Power(a, b);
            Assert.That(test, Is.EqualTo(result));
        }
        #endregion

        #region Divide Test
        [TestCase(2, 2, 1)]
        [TestCase(5, 2, 2.5)]
        [TestCase(56, 7, 8)]
        [Test]
        public void TestOfDivide_MulitpleNumbes(double a, double b, double result)
        {
            var test = _uut.Divide(a, b);
            Assert.That(test, Is.EqualTo(result));
        }
        #endregion

        #region Overloaded Add Test
        [TestCase(2, 2, 6)]
        [TestCase(5, 2, 9)]
        [TestCase(10.5, 7.3, 25.1)]
        public void TestOfOverloadedAdd_MulitpleNumbes(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Add(a, b);
            var test2 = _uut.Add(b);
            Assert.That(test2, Is.EqualTo(result));
        }
        #endregion

        #region Overloaded Subtract Test
        [TestCase(10, 2, 6)]
        [TestCase(20.5, 10, 0.5)]
        [TestCase(30, -10, 50)]
        public void TestOfOverloadedSubtract_MulitpleNumbes(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Subtract(a, b);
            var test2 = _uut.Subtract(b);
            Assert.That(test2, Is.EqualTo(result));
        }
        #endregion

        #region Overloaded Multiply Test
        [TestCase(3, 5, 75)]
        [TestCase(5, -2, 20)]
        [TestCase(5.5, 2, 22)]
        public void TestOfOverloadedMultiply_MulitpleNumbes(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Multiply(a, b);
            var test2 = _uut.Multiply(b);
            Assert.That(test2, Is.EqualTo(result));
        }
        #endregion

        #region Overloaded Power Test
        [TestCase(2, 2, 16)]
        [TestCase(5, 2, 33554432)]
        [TestCase(2, 4, 4294967296)]
        [TestCase(-1, 2, 2)]
        [Test]
        public void TestOfOverloadedPower_MulitpleNumbes(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Power(a, b);
            var test2 = _uut.Power(b);
            Assert.That(test2, Is.EqualTo(result));
        }
        #endregion

        #region Overloaded Divide Test
        [TestCase(10, 2, 2.5)]
        [TestCase(20.5, 10, 0.205)]
        [TestCase(80, 8, 1.25)]
        public void TestOfOverloadedDivide_MulitpleNumbes(double a, double b, double result)
        {
            _uut.Clear();
            var test1 = _uut.Divide(a, b);
            var test2 = _uut.Divide(b);
            Assert.That(test2, Is.EqualTo(result).Within(1E-14));
        }
        #endregion

        #region Divide By Zero Exception Test
        [TestCase(10, 0)]
        [TestCase(20.5, 0)]
        [TestCase(80, -0)]
        public void TestOfDivideByZeroException(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(a, b));
        }
        #endregion
    }
}