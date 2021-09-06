using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_testing
{
    class Utility
    {
        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>string type binary value</returns>
        public static string ToBinary(int input)
        {
            string binary = string.Empty;
            while (input > 0)
            {
                int addBinary = input % 2;
                binary = addBinary + string.Empty + binary;
                input = input / 2;
            }

            return binary;
        }

        /// <summary>
        /// Converts to decimal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>double type decimal value</returns>
        public static double ToDecimal(int input)
        {
            double decimalValue = 0;
            int count = 0;
            while (input > 0)
            {
                int power = input % 10;
                decimalValue += Math.Pow(2, count) * power;
                input = input / 10;
                count++;
            }

            return decimalValue;
        }

    }
}
