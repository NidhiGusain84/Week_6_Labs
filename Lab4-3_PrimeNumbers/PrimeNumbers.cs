using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_3_PrimeNumbers
{
   public static class PrimeNumbers
   {

        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int i = 2;
            while(i <= n / 2)
            {
                if (n % i == 0)
                {
                    return false;
                   
                }
                i++;
            }

            return true;
        }
        public static  int GetPrime(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            int primes = 1;
            int i = 3;
            while(true)
            {
                if (IsPrime(i))
                {
                    primes += 1;
                }
                if (primes == n)
                {
                    break;
                }
                i++;
            }
            return i;
        }

       



   }
}
