namespace CSharpProjectEulerSolutions.UnitTests;

public class AmicableNumbers
{
    public AmicableNumbers()
    {
    }

    public List<int> ProperDivisors(int number)
    {
        var properDivisors = new List<int>();

        if (number == 0)
        {
            properDivisors.Add(1);
            return properDivisors;
        }

        for (int i = number; i > 1; i--)
        {
            if (number % i == 0)
            {
                int properDivisor = number / (int)i;
                properDivisors.Add(properDivisor);
            }
        }

        return properDivisors;
    }

    internal object SumOfArray(List<int> numbersList)
    {
        throw new NotImplementedException();
    }
}