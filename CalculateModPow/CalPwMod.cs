using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//Source code: https://helloacm.com/compute-powermod-abn/

namespace CalculateModPow
{
    public class CalPwMod
    {
        public BigInteger PowMod(BigInteger _base, BigInteger _exponent, BigInteger _modular)
        {
            if (_exponent == 1)
                return BigInteger.ModPow(_base, 1, _modular);
            BigInteger _result = PowMod(_base, _exponent / 2, _modular);
            _result = BigInteger.ModPow(_result, _result, _modular);

            if ((_exponent & 1) == 1)
                _result = BigInteger.ModPow(_result, _base, _modular);
            return _result;
        }


        /*
         * It is the same as this:
          def powermod3(a, b, n):
            r = 1
            while b > 0:
                if b & 1 == 1:# odd number
                    r = r * a % n
                b /= 2
                a = a * a % n
            return r
         */
    }
}
