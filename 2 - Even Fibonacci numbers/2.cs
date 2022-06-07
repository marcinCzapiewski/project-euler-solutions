namespace ProjectEulerSolutions
{
    internal class P2
    {
        public static int SumOfEvenFibonaciNumbersWithValueLessThanGivenNumber(int boundary)
        {
            var sum = 0;

            var currentValue = 0;

            for (int i = 1; currentValue < boundary; i++)
            {
                currentValue = GetFibonacciNumberIteratively(i);

                if (currentValue % 2 == 0)
                {
                    sum += currentValue;
                }
            }

            return sum;
        }

        public static int GetFibonacciNumberRecursively(int i)
        {
            var first = 1;
            var second = 2;

            if (i < 1)
            {
                throw new InvalidOperationException();
            }

            if (i == 1)
            {
                return first;
            }

            if (i == 2)
            {
                return second;
            }

            return GetFibonacciNumberRecursively(i - 1) + GetFibonacciNumberRecursively(i - 2);
        }

        public static int GetFibonacciNumberIteratively(int i)
        {
            var previousNumber = 1;
            var currentNumber = 2;

            if (i < 1)
            {
                throw new InvalidOperationException();
            }

            if (i == 1)
            {
                return previousNumber;
            }

            if (i == 2)
            {
                return currentNumber;
            }

            for (int j = 3; j <= i; j++)
            {
                var temp = previousNumber;
                previousNumber = currentNumber;
                currentNumber = temp + previousNumber;
            }

            return currentNumber;
        }
    }
}
