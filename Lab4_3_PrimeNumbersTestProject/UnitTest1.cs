using System;
using Xunit;
using Lab4_3_PrimeNumbers;

namespace Lab4_3_PrimeNumbersTestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(11, true)]
        [InlineData(18, false)]
        [InlineData(37, true)]
        [InlineData(53, true)]
        [InlineData(61, true)]
        [InlineData(77, false)]
        public void IsPrimeTest(int num, bool expected)
        {
            bool result = PrimeNumbers.IsPrime(num);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(3, 5)]
        [InlineData(8, 19)]
        [InlineData(15, 47)]
        [InlineData(18, 61)]
       
        public void GetPrimeTest(int num, int expected)
        {
            int actual = PrimeNumbers.GetPrime(num);
            Assert.Equal(expected, actual);

        }

    }
}
