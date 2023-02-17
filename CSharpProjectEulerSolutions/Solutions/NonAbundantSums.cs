namespace CSharpProjectEulerSolutions
{
    public class NonAbundantSums
    {
        public NonAbundantSums()
        {
        }

        public int SumOfNonAbundantSums()
        {
            const int upperLimit = 28123;

            int[] numbers = Enumerable.Range(1, upperLimit).ToArray();

            List<int> abundantNumbers = new();
            for (int i = 1; i <= upperLimit; i++)
            {
                int divisorsSum = new AmicableNumbers().SumOfNumber(i);
                if (divisorsSum > i)
                {
                    abundantNumbers.Add(i);
                }
            }

            HashSet<int> abundantSums = new();
            foreach (var x in abundantNumbers)
            {
                foreach (var y in abundantNumbers)
                {
                    int sum = x + y;
                    if (sum <= upperLimit)
                    {
                        abundantSums.Add(sum);
                    }
                }
            }

            int result = numbers.Where(x => !abundantSums.Contains(x)).Sum();

            return result;
        }

        internal int Solve()
        {
            return SumOfNonAbundantSums();
        }
    }
}