namespace ProjectEulerSolutions
{
    internal class P3
    {
        public static long SmarterLargestPrimeFactor(long number)
        {
            var currentNumber = number;
            var largestFactor = 0L;
            for (long i = 2; i * i < number;)
            {
                if (currentNumber % i == 0)
                {
                    currentNumber /= i;
                    largestFactor = i;
                }
                else
                {
                    i++;
                }
            }

            if (currentNumber > largestFactor)
            {
                largestFactor = currentNumber;
            }

            return largestFactor;
        }

        public static long DumbLargestPrimeFactor(long number)
        {
            var allFactors = new List<long>();

            for (long i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    allFactors.Add(i);
                }
            }

            var primeFactors = new List<long>();

            foreach (var factor in allFactors)
            {
                if (IsPrimeNumber(factor))
                {
                    primeFactors.Add(factor);
                }
            }

            return primeFactors.Last();
        }

        private static bool IsPrimeNumber(long number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (long i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
