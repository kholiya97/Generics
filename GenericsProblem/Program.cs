using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaximumNumbers
    {
        /// <summary>
        /// This method returns largest numbers among all 3 float numbers 
        /// </summary>
        /// <param name="firstValue">firstValue is of float type</param>
        /// <param name="secondValue">secondValue is of float type</param>
        /// <param name="thirdValue">thirdValue is of float type</param>
        /// <returns></returns>
        public static float MaxFloatNumber(float firstnumb, float secondnumb, float thirdnumb)
        {
            if (firstnumb.CompareTo(secondnumb) > 0 && firstnumb.CompareTo(thirdnumb) > 0)
            {
                return firstnumb;
            }
            else if (secondnumb.CompareTo(firstnumb) > 0 && secondnumb.CompareTo(thirdnumb) > 0)
            {
                return secondnumb;
            }
            else if (thirdnumb.CompareTo(firstnumb) > 0 && thirdnumb.CompareTo(secondnumb) > 0)
            {
                return thirdnumb;
            }
            else
            {
                Console.WriteLine("all 3 numbers are same");
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Find MaximumProblem using Generics");

            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 6.5f, 2.2f));
            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 66.5f, 3f));
            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.46f, 65.5f, 231.2f));

            Console.Read();
        }
    }
}
