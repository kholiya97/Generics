using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericsProblem;

namespace MSTestMaxNumber
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
        [TestMethod]
        [DataRow(643, 353, 532)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionOneShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {

            int expectedResult = firstValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(423, 4453, 532)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionTwoShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(233, 553, 932)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionThreeShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
