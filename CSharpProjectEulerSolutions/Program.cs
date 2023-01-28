using System.Diagnostics;

if (args.Length == 0)
{
    string? s;
    do
    {
        Console.WriteLine("\n***************************************************************************************");
        Console.WriteLine("The following problems are taken from Project Euler at https://projecteuler.net/archives \n");
        Console.Write("Enter the Problem number or Space to Exit: ");
        s = Console.ReadLine();
        if (!String.IsNullOrWhiteSpace(s))
        {
            appMenu(s.Trim());
        }
    } while (s != " "); // Space & Enter Kill the process
    Process.GetCurrentProcess().Kill();
}
else
{
    appMenu(args[0]);
}

static void appMenu(string problemId)
{
    var projectEuler = new ProjectEuler();

    switch (problemId)
    {
        case "1":
            projectEuler.p1();
            break;
        case "2":
            projectEuler.p2();
            break;
        case "19":
            projectEuler.p19();
            break;
        case "20":
            projectEuler.p20();
            break;
        default:
            Console.WriteLine($"There is no solution for the problem # {problemId} yet. Please try it later. Thanks! \n");
            break;
    }
}