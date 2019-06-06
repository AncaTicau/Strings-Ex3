using System;
using System.Globalization;

namespace Strings_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumOfDigits = SumOfDigits("A5d6b8");


            Console.WriteLine(sumOfDigits);

            Console.ReadKey();
        }

        // Write a method to compute sum of digits of a given string(if any).

        public static int SumOfDigits(string givenString)
        {
            int result = 0;

            for (int i = 0; i < givenString.Length; i++)
            {

                if (!int.TryParse(givenString[i].ToString(), NumberStyles.None, CultureInfo.InvariantCulture, out int digit))
                {
                    continue;
                }

                result += digit;

            }

            return result;

        }
    }
}
