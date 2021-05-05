using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericsProblem;

namespace MSTestMaxNumber
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// TC1.1 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(66.3f, 5.3f, 4.2f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionOneShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = firstValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// TC1.2 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(33.2f, 445.3f, 5.22f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionTwoShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = secondValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(63.3f, 6.53f, 93.2f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionThreeShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = thirdValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
    }
}