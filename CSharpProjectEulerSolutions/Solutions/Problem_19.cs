using System.Diagnostics;

public partial class ProjectEuler
{

    // The following problem is taken from Project Euler.
    // http://projecteuler.net/problem=19
    /*********** Counting Sundays ****************** */
    /*
        You are given the following information, but you may prefer to do some research for yourself.

        1 Jan 1900 was a Monday.
        Thirty days has September,
        April, June and November.
        All the rest have thirty-one,
        Saving February alone,
        Which has twenty-eight, rain or shine.
        And on leap years, twenty-nine.
        A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
     */

    public void p19()
    {
        Console.WriteLine("Project Euler Problem #19:");

        var exeTime = Stopwatch.StartNew();

        var startDate = new DateOnly(1901, 1, 1);
        var endDate = new DateOnly(2000, 12, 31);

        var sum = GetNoOfSundaysForDateSpan(startDate, endDate);

        Console.WriteLine($"Answer for the Problem #19 is : {sum}");

        exeTime.Stop();

        Console.WriteLine($"Execution Time : {exeTime.ElapsedMilliseconds}");
    }

    public static int GetNoOfSundaysForDateSpan(DateOnly startDate, DateOnly endDate)
    {
        var countSundays = 0;

        var noOfMonths = endDate.Month;

        while (startDate.Year < endDate.Year + 1)
        {
            for (var j = 1; j < noOfMonths + 1; j++)
            {
                if (startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    countSundays++;
                    Console.WriteLine($" ---> Using while loop: {startDate} - {j}");
                }
                startDate = startDate.AddMonths(1);
            }
        }

        return countSundays;
    }

    public static int GetNoOfSundaysForDateSpan(DateOnly startDate, DateOnly endDate, string type)
    {
        var countSundays = 0;

        for (var y = 1901; y <= 2000; y++)
        {
            for (var m = 1; m <= 12; m++)
            {
                if (new DateOnly(y, m, 1).DayOfWeek == DayOfWeek.Sunday)
                {
                    countSundays++;
                    Console.WriteLine($" ---> Using for loop: {startDate} - {y}");
                }
            }
        }

        return countSundays;
    }
}