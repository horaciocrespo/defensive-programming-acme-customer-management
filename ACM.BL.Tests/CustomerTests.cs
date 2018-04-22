using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Tests
{
    /// <summary>
    /// Test one test case in each test method.
    /// Use a structure like arrange, act and assert.
    /// Try to make the test method self-documenting. Good name methods.
    /// </summary>
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CaculatePercentOfGoalStepsTestValid()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePercentOfGoalStepsDecimalTestValid()
        {
            var customer = new Customer();
            decimal goalStepsCount = 5000M;
            decimal actualStepsCount = 2000M;
            decimal expected = 40M;

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalsStepsDecimalTestValidActualIsZero()
        {
            var customer = new Customer();
            decimal goalStepsCount = 5000M;
            decimal actualStepsCount = 0M;
            decimal expected = 0M;

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalsStepsDecimalTestValidAndSame()
        {
            var customer = new Customer();
            decimal goalStepsCount = 5000M;
            decimal actualStepsCount = 5000M;
            decimal expected = 100M;

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalsStepsTestGoalIsNull()
        {
            var customer = new Customer();
            string goalStepsCount = null;
            string actualStepsCount = "2000";

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalsStepsTestActualIsNull()
        {
            var customer = new Customer();
            string goalStepsCount = "5000";
            string actualStepsCount = null;

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalsStepsTestActualAndActualIsNull()
        {
            var customer = new Customer();
            string goalStepsCount = null;
            string actualStepsCount = null;

            var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalsStepsTestGoalIsNotNumeric()
        {
            var customer = new Customer();
            string goalStepsCount = "one";
            string actualStepsCount = "2000";

            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Goal must be numeric", e.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalsStepsTestActualIsNotNumeric()
        {
            var customer = new Customer();
            string goalStepsCount = "5000";
            string actualStepsCount = "two";

            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Actual steps must be numeric", e.Message);
                throw;
            }
        }
    }
}
