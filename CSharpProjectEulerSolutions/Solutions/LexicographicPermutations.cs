namespace CSharpProjectEulerSolutions;

public class LexicographicPermutations
{
    public LexicographicPermutations()
    {
    }

    public string GetNthPermutation(int[] digits, int n)
    {

        int[] factorials = FactorialsOfNumbers0To9();

        Array.Sort(digits);

        int[] indices = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            int factorial = factorials[digits.Length - i - 1];
            int index = (n - 1) / factorial;
            indices[i] = index;
            n -= index * factorial;
        }

        string result = string.Join("", digits.Select((x, i) =>
        {
            int index = indices[i];
            int digit = digits[index];
            int[] newDigits = digits.Where((y, j) => j != index).ToArray();
            digits = newDigits;
            return digit.ToString();
        }));

        return result;
    }

    private static int[] FactorialsOfNumbers0To9()
    {
        int[] factorials = new int[10];
        factorials[0] = 1;

        for (int i = 1; i < 10; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }

        return factorials;
    }
}