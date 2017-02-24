using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClimbingStairs;

namespace Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Test_ClimbStairs_4()
        {
            // Arrange
            int n = 4;
            int expected = 5;
            int actual;

            // Act
            actual = Solution.ClimbStairs(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ClimbStairs_6()
        {
            // Arrange
            int n = 6;
            int expected = 13;
            int actual;

            // Act
            actual = Solution.ClimbStairs(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
