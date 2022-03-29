using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class HigherOrderBitMask
    {
        #region MyRegion
        //When working with binary numbers, we can use bitmasks to turn on/off certain bits.
        /// For example, if we take the binary representation of the decimal value 220 (1101 1100)
        /// and we wanted to extract the higher 4 bits, we could use a bitmask with the boolean AND operation:
        ///   1101 1100 (220)
        ///   AND  1111 0000 (240)
        ///   _________
        ///   1101 0000 (208)
        ///Put simply, 220 AND 240 is 208. 240 acts as our bitmask while 208 is the value

        #endregion

        public int HigherOrderBitMasks(int wordSize)
        {
            string bitMask = "";
            for (int i = 0; i < wordSize; i++)
            {
                if (i < wordSize / 2)
                {
                    bitMask += 1;
                }

                bitMask += 0;
            }

            return Convert.ToInt32(bitMask, 2);
        }
    }
}
