using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

namespace LiThuyetSo
{
    class RandomNumber:Random
    {
        public BigInteger getRandom(int length)
        {
            BitArray bits;
            byte[] b = new byte[length / 8];
            NextBytes(b);

            bits = new BitArray(b);
            

            BigInteger result = 0;
            for(int i=(bits.Count-1);  i>=0; i--)
            {
                BigInteger value = 0;

                if(bits[i])
                    value = BigInteger.Pow(2, i);

                result = BigInteger.Add(result, value);
            }

            return result;
        }
    }
}
