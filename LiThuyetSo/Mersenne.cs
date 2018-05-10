using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LiThuyetSo
{
    class Mersenne
    {
        private int[] exponent = { 2, 3, 5, 7, 13, 17, 19, 31, 61, 89};

        public List<BigInteger> MersenneResult()
        {
            List<BigInteger> result = new List<BigInteger>();

            int i = 0;
            while (i<10)
            {
                result.Add(BigInteger.Subtract(BigInteger.Pow(2, exponent.ElementAt(i)), 1));
                i++;
            }

            return result;
        }

    }
}
