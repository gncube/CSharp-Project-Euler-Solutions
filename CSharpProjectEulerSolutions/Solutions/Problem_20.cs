using CSharpProjectEulerSolutions;
using System.Diagnostics;

public partial class ProjectEuler
{

    // The following problem is taken from Project Euler.
    // http://projecteuler.net/problem=20
    /*********** Factorial digit sum ****************** */
    /*
        n! means n × (n − 1) × ... × 3 × 2 × 1

        For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

        Find the sum of the digits in the number 100!
     */

    public void p20()
    {
        Console.WriteLine("Project Euler Problem #20:");

        var exeTime = Stopwatch.StartNew();

        var sum = 0;

        int n = 100;

        var processor = new FactorialDigitSum();

        sum = processor.GetDigitsSum(n);

        Console.WriteLine($"Answer for the Problem #20 is : {sum}");

        exeTime.Stop();

        Console.WriteLine($"Execution Time : {exeTime.ElapsedMilliseconds}");
    }
}