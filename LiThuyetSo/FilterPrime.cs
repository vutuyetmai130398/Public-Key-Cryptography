using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//Source code: https://stackoverflow.com/questions/32035259/fastest-algorithm-to-find-if-a-biginteger-is-a-prime-number-or-not

namespace LiThuyetSo
{
    class FilterPrime:Mersenne
    {
        public FilterPrime() : base() { }

        public List<BigInteger> FilterPrimeNumber(BigInteger min, BigInteger max)
        {
            List<BigInteger> result = new List<BigInteger>();
            Primality _testPrime = new Primality();

            if (max == 3)
            {
                result.Add(2);
            }
           
            else
            {
                int i = 0;
                for (BigInteger index = BigInteger.Subtract(max, 2); index > min; index = BigInteger.Subtract(index, 2))
                {
                    if (i >= 10 || index<=min) break;
                    if (_testPrime.IsPrimeMillerRabin(index))
                    {
                        result.Add(index);
                        i = result.Count();

                    }
                   
                }
            }
             return result;
        }

    }
}
