namespace CSharpProjectEulerSolutions
{
    public class NameScores
    {
        public NameScores()
        {
        }

        public int AlphabeticalValue(string name)
        {
            return name.ToCharArray().Sum(c => c - 'A' + 1);
        }

        public int Solve(string[] names)
        {
            return names
                .OrderBy(name => name)
                .Select((name, index) => AlphabeticalValue(name) * (index + 1))
                .Sum();

        }
    }
}