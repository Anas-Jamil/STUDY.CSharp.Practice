using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.UnitTests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void Addition_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            float result = Calculator.Additon(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtraction_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            float result = Calculator.Subtraction(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiplication_TwoNumbers_ReturnsCorrectProduct()
        {
            float result = Calculator.Multiplication(7, 6);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void Division_TwoNumbers_ReturnsCorrectQuotient()
        {
            float result = Calculator.Divide(12, 3);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Division_ByZero_ReturnsInfinity()
        {
            float result = Calculator.Divide(10, 0);
            Assert.AreEqual(float.PositiveInfinity, result);
        }
    }
}
