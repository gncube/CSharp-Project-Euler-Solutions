using CSharpProjectEulerSolutions;
using System.Diagnostics;

public partial class ProjectEuler
{

    // The following problem is taken from Project Euler.
    // http://projecteuler.net/problem=22
    /*********** Names scores ****************** */
    /*
        Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

        For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

        What is the total of all the name scores in the file?
     */

    public void p22()
    {
        Console.WriteLine("Project Euler Problem #22:");

        var exeTime = Stopwatch.StartNew();

        var sum = 0;

        var filePath = @"C:\REPOS\CSharp-Project-Euler-Solutions\CSharpProjectEulerSolutions.UnitTests\p022_names.txt";
        string[] names = File.ReadAllText(filePath)
            .Replace("\"", "")
            .Split(',')
            .ToArray();

        var processor = new NameScores();
        sum = processor.Solve(names);

        Console.WriteLine($"Answer for the Problem #2 is : {sum}");

        exeTime.Stop();

        Console.WriteLine($"Execution Time : {exeTime.ElapsedMilliseconds}");
    }
}