namespace dojo.FizzBuzz.Rules
{
    public class FizzBuzzRule(string fizzedWord,
                                     int numberToDevideBy) : IFizzBuzzRule
    {
        internal readonly string FizzedWord = fizzedWord;
        public string Result { get; private set; } = string.Empty;
        internal int NumberToDevideBy => numberToDevideBy;

        public bool Parse(int i)
        {
            if (i % NumberToDevideBy == 0)
            {
                Result = FizzedWord;
                return true;
            }
            Result = i.ToString();
            return false;
        }
    }
}