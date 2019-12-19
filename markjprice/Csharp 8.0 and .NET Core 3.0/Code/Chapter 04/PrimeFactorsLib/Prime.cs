using System;

namespace PrimeFactorsLib
{
    /// <summary>Library of methods for the PrimeFactors project.</summary>
    public class PrimeFactors
    {
        public int largest = 0;
        public int original = 0;
        private int countPrimes = 0;
        public int[] primes = new int[short.MaxValue];
        public int[] primeFactors = new int[short.MaxValue];

        public PrimeFactors(int largest, int original)
        {
            this.largest = largest;
            this.original = original;
            int index = 0;
            count();
            setPrimes();
            Array.Resize(ref primes, countPrimes);
            for (int i = primes.Length - 1; i >= 0 ; i--)
            {
                if ((original % primes[i]) == 0)
                {
                    primeFactors[index] = primes[i];
                    index++;
                }
            }
            Array.Resize(ref primeFactors, index);
        }

        public string Print()
        {
            int i = 0;
            int remainder = this.original;
            string result = "";
            result += $"Prime factors of {this.original} are: ";
            while (remainder > 1) 
            {
                result += $"{this.primeFactors[i]}";
                remainder /= this.primeFactors[i];
                if (remainder > 1) {
                    result += " x ";
                }
                if ((remainder % this.primeFactors[i]) != 0) {
                    i++;
                }
            }
            return result;
        }
        private void count()
        {
            for (int i = 2; i <= largest; i++)
            {
                if (isPrime(i))
                {
                    this.countPrimes++;
                }
            }
        }
        
        // isPrime courtesy of 
        //https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not
        private static bool isPrime(int p) 
        {
            int index = 0;
            for (int i = 1; i <= p; i++) 
            {
                if (p % i == 0) 
                {
                    index++;
                }
            }
            if (index == 2)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        private void setPrimes()
        {
            int index = 0;
            for (int i = 2; i <= largest; i++)
            {
                if (isPrime(i))
                {
                    primes[index] = i;
                    index++;
                }
            }
        }
    }
}

