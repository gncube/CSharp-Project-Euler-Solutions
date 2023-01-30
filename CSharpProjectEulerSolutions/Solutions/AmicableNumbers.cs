namespace CSharpProjectEulerSolutions;

/*https://stackoverflow.com/questions/36439222/project-euler-21
 */

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

    public List<int> GetAmicableNumbers(int a)
    {
        var amicableNumbers = new List<int>();
        var da = SumOfArray(ProperDivisors(a));
        int b = da;
        var db = SumOfArray(ProperDivisors(b));

        if ((da == b) & (db == a) & (a != b))
        {
            amicableNumbers.Add(a);
            amicableNumbers.Add(b);
        }

        return amicableNumbers;
    }

    public int SumOfArray(List<int> numbersList)
    {
        return numbersList.Sum();
    }
}