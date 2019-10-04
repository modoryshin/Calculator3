using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSE.SQAT.CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(1.1,0.9,2)]
        [DataRow(1,-3,-2)]
        [TestCategory("FunctionExecution")]
        public void PressPlusTwoItem(double value1,double value2,double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("#",1,3)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("FunctionExecution")]
        public void PressPlusNonDoubleTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }
        [DataTestMethod]
        [DataRow(3,5,15)]
        [DataRow(3, -5, -15)]
        [DataRow(3.5, 1.2, 4.2)]
        [TestCategory("FunctionExecution")]
        public void PressMultiplyTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMultiply();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(1, "#", 3)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("FunctionExecution")]
        public void PressMultiplyNonDoubleTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }
        [DataTestMethod]
        [DataRow(1,17,34,2)]
        [DataRow(1, 17, -34, -2)]
        [TestCategory("FunctionExecution")]
        public void PressDivideMultiplyTwoItem(double value1,double value2,double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressMultiply();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(1, "@", "%", 2)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("FunctionExecution")]
        public void PressDivideMultiplyNonDoubleTwoItem(double value1, double value2, double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressMultiply();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }
        [DataTestMethod]
        [DataRow(1, 0, 2)]
        [TestCategory("FunctionExecution")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PressDivideZeroTwoItem(double value1,double value2,double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }

        [DataTestMethod]
        [DataRow(1,2,0.5)]
        [DataRow(1.5,-2,-0.75)]
        [TestCategory("FunctionExecution")]
        public void PressDivideTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(1, "$", 2)]
        [TestCategory("FunctionExecution")]
        [ExpectedException(typeof(ArgumentException))]
        public void PressDivideNonDoubleTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }
        [DataTestMethod]
        [DataRow(1,2,3,6)]
        [DataRow(1.5, 2, -3, 0.5)]
        [TestCategory("FunctionExecution")]
        public void PressPlusThreeItem(double value1, double value2, double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressPlus();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3,2,1)]
        [DataRow(2, 3, -1)]
        [TestCategory("FunctionExecution")]
        public void PressMinusTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(3,"!",1)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("FunctionExecution")]
        public void PressMinusNonDoubleTwoItem(double value1, double value2, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.Fail();
        }
        [DataTestMethod]
        [DataRow(3,2,2,-1)]
        [TestCategory("FunctionExecution")]
        public void PressMinusThreeItem(double value1, double value2, double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressMinus();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3, 2, 2, 3)]
        [TestCategory("FunctionExecution")]
        public void PressPlusMinusThreeItem(double value1, double value2, double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressMinus();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(3,2,1,2)]
        [TestCategory("FunctionExecution")]
        public void PressMinusPlusThreeItem(double value1, double value2, double value3, double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressPlus();
            calculator.PressDisplay(value3);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(1,2,3)]
        [TestCategory("InputData")]
        public void PositiveNumericValues(double value1,double value2,double expected)
        {
            PressPlusTwoItem(value1, value2, expected);
        }
        [DataTestMethod]
        [DataRow(-1, -2, -3)]
        [TestCategory("InputData")]
        public void NegativeNumericValues(double value1, double value2, double expected)
        {
            PressPlusTwoItem(value1, value2, expected);
        }
        [DataTestMethod]
        [DataRow(1, "#", 3)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("InputData")]
        public void NonNumericValues(double value1, double value2, double expected)
        {
            PressPlusNonDoubleTwoItem(value1, value2, expected);
        }
        [DataTestMethod]
        [DataRow(3,2,1,2)]
        [TestCategory("OutputData")]
        public void OutPositiveValue(double value1, double value2, double value3, double expected)
        {
            PressMinusPlusThreeItem(value1,value2, value3,expected);
        }

        [DataTestMethod]
        [DataRow(3, 2, 2, -1)]
        [TestCategory("OutputData")]
        public void OutNegativeValue(double value1, double value2, double value3, double expected)
        {
            PressMinusThreeItem(value1,value2,value3,expected);
        }

        [DataTestMethod]
        [DataRow(1,1,0)]
        [TestCategory("OutputData")]
        public void OutZero(double value1,double value2,double expected)
        {
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(3, "!", 1)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("OutputData")]
        public void OutException(double value1,double value2, double expected)
        {
            PressMinusNonDoubleTwoItem(value1, value2, expected);
        }
        [DataTestMethod]
        [DataRow(1, "#", 3)]
        [ExpectedException(typeof(ArgumentException))]
        [TestCategory("PermissibleValuesRange")]
        public void NonNumericValuesInput(double value1, double value2, double expected)
        {
            PressPlusNonDoubleTwoItem(value1, value2, expected);
        }
        [DataTestMethod]
        [DataRow(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },55)]
        [TestCategory("LengthInputData")]
        public void PresPlusTenItem(double[] array,double expected)
        {
            // Act.
            var calculator = new Calculator();
            foreach (var item in array)
            {
                calculator.PressDisplay(item);
                calculator.PressPlus();
            }
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 5050)]
        [TestCategory("LengthInputData")]
        public void PresPlusHundredItem(double[] array, double expected)
        {
            // Act.
            var calculator = new Calculator();
            foreach (var item in array)
            {
                calculator.PressDisplay(item);
                calculator.PressPlus();
            }
            var actual = calculator.PressEnter();
            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
