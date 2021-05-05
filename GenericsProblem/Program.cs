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
        /// This method returns largest numbers among all 3 integer numbers 
        /// </summary>
        /// <param name="firstValue">firstValue is of integer type</param>
        /// <param name="secondValue">secondValue is of integer type</param>
        /// <param name="thirdValue">thirdValue is of integer type</param>
        /// <returns></returns>
        public static int MaxIntNumber(int firstnumb, int secondnumb, int thirdnumb)
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
            Console.WriteLine(MaximumNumbers.MaxIntNumber(786, 60, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(70, 733, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(943, 73, 3312));
            Console.Read();
        }
    }
}
