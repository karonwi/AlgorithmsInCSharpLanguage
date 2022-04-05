using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    internal class ParityOutlier
    {
        #region Question
       /* You are given an array(which will have a length of at least 3, but could be very large) containing integers.
        The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
       Write a method that takes the array as an argument and returns this "outlier" N.

            Examples
        [2, 4, 0, 100, 4, 11, 2602, 36]
        Should return: 11 (the only odd number)

        [160, 3, 1719, 19, 11, 13, -21]
        Should return: 160 (the only even number)
        */

        #endregion
        using System.Collections.Generic;
        using System.Linq;
        using System;

        public class Kata
        {
            public static int Find(int[] integers)
            {
            int Even = 0;
            int Odd = 0;
            int N = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }
            for (int i = 0; i < integers.Length; i++)
            {

                if (Even > Odd && integers[i] % 2 != 0)
                {
                    N += integers[i];
                }
                else if (Odd > Even && integers[i] % 2 == 0)
                {
                    N += integers[i];
                }
            }
            return N;
        }
        }
}
}
