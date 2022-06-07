namespace ProjectEulerSolutions
{
    internal class P1
    {
        public static int GetSumOfMultiplesOf3Or5BelowGivenNumber(int boundary)
        {
            var sum = 0;

            var naiveCounter = 0;
            for (int i = 3; i < boundary; i++)
            {
                naiveCounter++;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Obvious implementation: {naiveCounter}, result: {sum}");

            var betterImplementationCounter = 0;
            var butterImplementationSum = 0;
            for (int i = 3; i < boundary; i += 3)
            {
                betterImplementationCounter++;

                if (i % 3 == 0)
                {
                    butterImplementationSum += i;
                }
            }

            for (int i = 5; i < boundary; i += 5)
            {
                betterImplementationCounter++;
                if (i % 3 == 0)
                {
                    continue;
                }

                if (i % 5 == 0)
                {
                    butterImplementationSum += i;
                }
            }

            Console.WriteLine($"Better implementation: {betterImplementationCounter}, result: {butterImplementationSum}");

            return sum;
        }
    }
}
