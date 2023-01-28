using System.Collections;
using System.Numerics;

namespace CSharpProjectEulerSolutions
{
    public class FactorialDigitSum
    {
        // Function to multiply x with large number
        // stored in vector v. Result is stored in v.

        static ArrayList v = new();
        static void multiply(int x)
        {
            int carry = 0;
            int size = v.Count;
            for (int i = 0; i < size; i++)
            {
                int res = carry + (int)v[i] * x;

                v[i] = res % 10;
                carry = res / 10;
            }

            while (carry != 0)
            {
                v.Add(carry % 10);
                carry /= 10;
            }
        }

        public int GetDigitsSum(BigInteger n)
        {
            v.Add(1);
            // One by one multiply j to current vector
            // and update the vector.
            for (int i = 1; i <= n; i++)
            {
                multiply(i);
            }

            // Find sum of digits in vector v[]
            int sum = 0;
            int size = v.Count;
            for (int j = 0; j < size; j++)
                sum += (int)v[j];
            return sum;
        }

        public BigInteger GetFactorial(int number)
        {
            var factorial = 1;
            if (number == 0)
            {
                return factorial;
            }

            for (var j = number; j > 0; j--)
            {
                factorial *= j;
            }

            return factorial;
        }
    }
}