using PrimeFactorsLib;
using System;
using Xunit;

namespace PrimeFactorsUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            string expected = "Prime factors of 4 are: 2 x 2";
            // act
            PrimeFactors a = new PrimeFactors(4);
            // assert
            Assert.Equal(expected, a.Print());
        }
        [Fact]
        public void Test2()
        {
            // arrange
            string expected = "Prime factors of 7 are: 7";                  // act
            // act
            PrimeFactors a = new PrimeFactors(7);
            // assert
            Assert.Equal(expected, a.Print());
        }
        [Fact]
        public void Test3()
        {
            // arrange
            string expected = "Prime factors of 30 are: 5 x 3 x 2";
            // act
            PrimeFactors a = new PrimeFactors(30);
            // assert
            Assert.Equal(expected, a.Print());
        }
        [Fact]
        public void Test4()
        {
            // arrange
            string expected = "Prime factors of 40 are: 5 x 2 x 2 x 2";
            // act
            PrimeFactors a = new PrimeFactors(40);
            // assert
            Assert.Equal(expected, a.Print());
        }
        [Fact]
        public void Test5()
        {
            // arrange
            string expected = "Prime factors of 50 are: 5 x 5 x 2";
            // act
            PrimeFactors a = new PrimeFactors(50);
            // assert
            Assert.Equal(expected, a.Print());
        }
    }
}
