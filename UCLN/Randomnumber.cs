using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UCLN
{
    class Randomnumber:Random
    {
        public BigInteger getRandom(int bitlength)
        {
            int bytes = bitlength / 8;
            int bits = bitlength % 8;

            // Generates enough random bytes to cover our bits.
            byte[] bs = new byte[bytes + 1];
            NextBytes(bs);

            // Mask out the unnecessary bits.
            byte mask = (byte)(0xFF >> (8 - bits));
            BitArray arr = new BitArray(mask);
            bs[bs.Length - 1] &= mask;

            return new BigInteger(bs);
        }
    }
}
