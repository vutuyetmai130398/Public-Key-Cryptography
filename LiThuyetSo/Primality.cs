using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

// Source code from: http://snipd.net/primality-testing-with-fermats-little-theorem-and-miller-rabin-in-c

namespace LiThuyetSo
{
    class Primality
    {
        public enum NumberType
        {
            Composite, Prime
        }

        public bool IsPrimeMillerRabin(BigInteger integer)
        {
            //If the number is prime return true
            NumberType type = MillerRabin(integer, 400);
            return type == NumberType.Prime;
        }

        //public bool IsPrimePseudo(BigInteger integer)
        //{
        //    NumberType type = PseudoPrime(integer);
        //    return type == NumberType.Prime;
        //}

        //private NumberType PseudoPrime(BigInteger integer)
        //{
        //    BigInteger modularExponentiation = ModularExponentiation(2, BigInteger.Subtract(integer, 1), integer);

        //    if (!modularExponentiation.IsOne)
        //        return NumberType.Composite;
        //    return NumberType.Prime;
        //}

        private NumberType MillerRabin(BigInteger integer, int v)
        {
            if (integer <= 1) return NumberType.Composite;
            if (integer == 2) return NumberType.Prime;
            //Have a prime number and substract its to 1 (integer -1)
            BigInteger integer1 = BigInteger.Subtract(integer, 1);

            //Loop run between 1 to another number
            for(int j=1; j<=v; j++)
            {
                //Generate the a random from 1 to int1
                BigInteger random = Random(1, integer1);


                if (Witness(random, integer))
                    return NumberType.Composite;
            }

            return NumberType.Prime;
        }

        private BigInteger Random(BigInteger min, BigInteger max)
        {
            //create the byte array to contains the bits which have the length = max integer
            byte[] maxbyte = max.ToByteArray();

            //change to array bit
            BitArray maxBits = new BitArray(maxbyte);
            Random random = new Random();

            //change the value of bit which is convert to decimal
            for (int i = 0; i< maxBits.Length; i++)
            {
                int randInt = random.Next();

                if ((randInt % 2) == 0)
                {
                    //reverse the bit
                    maxBits[i] = !maxBits[i];
                }
            }
            
            BigInteger result = new BigInteger();

            //Convert the bit to the decimal
            for(int k=(maxBits.Count-1); k>=0; k--)
            {
                BigInteger bitValue = 0;

                if (maxBits[k])
                {
                    bitValue = BigInteger.Pow(2, k);
                }

                result = BigInteger.Add(result, bitValue);
            }

            //Generate the random number
            BigInteger randomBigInt = BigInteger.ModPow(result, 1, BigInteger.Add(max, min));
            return randomBigInt;
        }

        private bool Witness(BigInteger random, BigInteger integer)
        {
            KeyValuePair<int, BigInteger> tAndU = GetTAndU(BigInteger.Subtract(integer, 1));
            int t = tAndU.Key;
            BigInteger u = tAndU.Value;
            BigInteger[] x = new BigInteger[t + 1];

            x[0] = ModularExponentiation(random, u, integer);

            for(int i=1; i<=t; i++)
            {
                x[i] = ModularExponentiation(BigInteger.Pow(x[i - 1], 2), 1, integer);

                BigInteger minus = BigInteger.Subtract(x[i - 1], BigInteger.Subtract(integer, 1));

                if (x[i] == 1 && x[i - 1] != 1 && !minus.IsZero)
                    return true;
                
            }

            if (!x[t].IsOne)
                return true;
            return false;
        }

        private BigInteger ModularExponentiation(BigInteger a, BigInteger u, BigInteger integer)
        {
            return BigInteger.ModPow(a, u, integer);
        }

        private KeyValuePair<int, BigInteger> GetTAndU(BigInteger bigInteger1)
        {
            //Convert n-1 tp a byte array
            byte[] nBytes = bigInteger1.ToByteArray();
            BitArray bits = new BitArray(nBytes);

            int t = 0;
            BigInteger result = new BigInteger();

            int n = bits.Count - 1;
            bool lastBit = bits[n];

            while (!lastBit)
            {
                t++;
                n--;
                lastBit = bits[n];
            }

            for(int k=((bits.Count-1)-t); k>=0; k--)
            {
                BigInteger bitValue = 0;

                if (bits[k])
                {
                    bitValue = BigInteger.Pow(2, k);
                }

                result = BigInteger.Add(result, bitValue);
            }

            KeyValuePair<int, BigInteger> tAndU = new KeyValuePair<int, BigInteger>(t, result);
            return tAndU;
        }
    }
}
