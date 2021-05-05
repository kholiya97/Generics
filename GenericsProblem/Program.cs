using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class MaximumNumbers
    {
        /// This method returns Maximum number in between 3 int numbers 
        public static int FindMaxInteger(int firstnumb, int secondnumb, int thirdnumb)
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
        /// <summary>
        /// This method returns Maximum number in between 3 float numbers 
        /// </summary>



        public static float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }

        /// <summary>
        ///  This method returns Maximum string in between 3 string 
        /// </summary>

        public static string MaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }

            return firstString;
        }
        public class PrintArray
        {
            public static void ToPrintInteger(int[] arr)
            {
                foreach (int element in arr)
                {
                    Console.Write(element + "\t");
                }
            }
            public static void ToPrintDouble(double[] arr)
            {
                foreach (double element in arr)
                {
                    Console.Write(element + "\t");
                }
            }

            public static void ToPrintCharacter(char[] arr)
            {
                foreach (char element in arr)
                {
                    Console.Write(element + "\t");
                }
            }
        }
    }
    public class PrintArray
    {
        public static void ToPrintInteger(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + "\t");
            }
        }
        public static void ToPrintDouble(double[] arr)
        {
            foreach (double element in arr)
            {
                Console.Write(element + "\t");
            }
        }

        public static void ToPrintCharacter(char[] arr)
        {
            foreach (char element in arr)
            {
                Console.Write(element + "\t");
            }
        }
    }
    public class Generic<T>
    {
        public T[] Number;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Number"></param>
        public Generic(T[] Number)
        {
            this.Number = Number;

        }

        /// <summary>
        /// This method is used for sorting the values
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public T[] Sort(T[] Number)
        {
            Array.Sort(Number);
            return Number;
        }
        void add(params int[] a) //specify a method parameter
        {

        }

        /// <summary>
        /// this method is created for finding max for given type
        /// params is used for optinal
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public T MaximumValue(params T[] Number)
        {
            var Sorte_Number = Sort(Number);
            return Sorte_Number[Sorte_Number.Length - 1];
        }

        /// <summary>
        /// This method is created calling MaximumValue method
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var MaxValue = MaximumValue(this.Number);
            return MaxValue;
        }

        /// <summary>
        /// This method is printing maximum generic value
        /// </summary>
        public void PrintValue()
        {
            var max = MaximumValue(this.Number);
            Console.Write(max);

        }
    }
    class Program
    {
        /// <summary>
        /// Entery point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Find MaximumProblem using Generics");
            Console.WriteLine();

            int[] Output = { 11, 22, 50, 60, 90 };
            Generic<int> genericInt = new Generic<int>(Output);//create object using int data type
            genericInt.PrintValue();
            Console.WriteLine();

            double[] Output1 = { 11.2, 22.5, 50.45, 55.92 };
            Generic<double> genericdouble = new Generic<double>(Output1);
            genericdouble.PrintValue();
            Console.WriteLine(
                );
            //String array
            string[] stringArray = { "111", "222", "333", "55", "999" };
            Generic<string> genericString = new Generic<string>(stringArray);
            genericString.PrintValue();
            Console.Read();

        }


    }
}
    