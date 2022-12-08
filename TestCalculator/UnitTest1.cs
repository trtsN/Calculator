using NUnit.Framework;
using Calculator;

namespace TestCalculator
{
    public class Tests
    {
        [TestCase(64, -70, -6)]
        [TestCase(0, 0, 0)]
        [TestCase(0.7, 0.4, 1.1)]
        [TestCase(double.MaxValue, 1, double.MaxValue)]
        public void AddMethod(double x, double y, double expected)
        {
            double actual = Program.Add(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(-50, 50, -100)]
        [TestCase(10, 0, 10)]
        [TestCase(5, 0.7, 4.3)]
        [TestCase(double.MaxValue, double.MaxValue, 0)]
        public void SubtractMethod(double x, double y, double expected)
        {
            double actual = Program.Subtract(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(2, 5, 10)]
        [TestCase(10, 0, 0)]
        [TestCase(-10, 50, -500)]
        public void MultiplyMethod(double x, double y, double expected)
        {
            double actual = Program.Multiply(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(-50, 50, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(double.MaxValue, double.MaxValue, 1)]
        public void Divideethod(double x, double y, double expected)
        {
            double actual = Program.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }


        [TestCase(-5, 2, -1)]
        [TestCase(10, 3, 1)]
        [TestCase(100, 100, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(double.MaxValue, double.MaxValue, 0)]
        public void ModuloMethod(double x, double y, double expected)
        {
            double actual = Program.Modulo(x, y);
            Assert.AreEqual(actual, expected);
        }


        [TestCase(0, 50, 0)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(50, 0, 1)]
        [TestCase(4, -1, 0.25)]
        public void ExponentiationMethod(double x, double y, double expected)
        {
            double actual = Program.Exponentiation(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(-50, 0)]
        [TestCase(4, 2)]
        public void SquareRootMethod(double x, double expected)
        {
            double actual = Program.SquareRoot(x);
            Assert.AreEqual(actual, expected);
        }
    }
}