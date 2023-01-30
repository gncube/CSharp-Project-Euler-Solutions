using CSharpProjectEulerSolutions;
using System.Diagnostics;

public partial class ProjectEuler
{

    // The following problem is taken from Project Euler.
    // http://projecteuler.net/problem=21
    /*********** Amicable numbers ****************** */
    /*
        Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

        For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. 
        The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

        Evaluate the sum of all the amicable numbers under 10000.
     */

    public void p21()
    {
        Console.WriteLine("Project Euler Problem #21:");

        var exeTime = Stopwatch.StartNew();

        var sum = 0;

        int n = 10000;

        var processor = new AmicableNumbers();
        var amicableArray = new List<int>();


        for (int i = 1; i <= n; i++)
        {
            var numbers = new List<int>();
            numbers = processor.GetAmicableNumbers(i);

            if (numbers.Count > 0)
            {
                Console.WriteLine($"--> {i} - {numbers.Count}");
                foreach( var number in numbers ) 
                { 
                    if (number < 10000)
                        amicableArray.Add(number);
                }
            }
        }



        Console.WriteLine($"Answer for the Problem #21 is : {processor.SumOfArray(amicableArray)}");

        exeTime.Stop();

        Console.WriteLine($"Execution Time : {exeTime.ElapsedMilliseconds}");
    }
}