namespace dojo.FizzBuzz.Rules
{
    public interface IFizzBuzzRule
    {
        int[] NumbersToDevideBy { get; }
        string Result { get; }

        bool Parse(int i);
    }

    public class FizzBuzzRule(string fizzedWord,
                                     params int[] numbersToDevideBy) : IFizzBuzzRule
    {
        internal readonly string FizzedWord = fizzedWord;
        public int[] NumbersToDevideBy => numbersToDevideBy;
        public string Result { get; private set; } = string.Empty;

        public bool Parse(int i)
        {
            if (i == 0)
            {
                Result = i.ToString();
                return false;
            }
            foreach (var number in NumbersToDevideBy)
            {
                if (i % number != 0)
                {
                    Result = i.ToString();
                    return false;
                }
            }

            Result = FizzedWord;
            return true;
        }
    }
}