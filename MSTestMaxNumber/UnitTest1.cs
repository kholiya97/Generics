using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericsProblem;

namespace MSTestMaxNumber
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray); //crating object with int data type
            int result = generic.MaxMethod();
            int max = 678;
            Assert.AreEqual(result, max);
        }


        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            double max = 55.5;
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "111", "222", "333", "55", "999" };
            Generic<string> genericString = new Generic<string>(stringArray);
            string result = genericString.MaxMethod();
            string max = "999";
            Assert.AreEqual(result, max);
        }
    }
}

