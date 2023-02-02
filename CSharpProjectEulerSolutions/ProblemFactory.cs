namespace CSharpProjectEulerSolutions
{
    public class ProblemFactory
    {
        public void Create(string problemId, ProjectEuler projectEuler)
        {
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
                case "21":
                    projectEuler.p21();
                    break;
                default:
                    Console.WriteLine($"There is no solution for the problem # {problemId} yet. Please try it later. Thanks! \n");
                    break;
            }
        }
    }
}
