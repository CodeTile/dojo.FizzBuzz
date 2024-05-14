using dojo.FizzBuzz.Rules;

namespace dojo.FizzBuzz
{
    public interface IFizzBuzz
    {
        void AddRule(IFizzBuzzRule rule);

        void ClearRules();

        string FizzOrBuzz(int i);
    }

    public class FizzBuzz : IFizzBuzz
    {
        public FizzBuzz()
        {
            DefaultRules();
        }

        internal List<IFizzBuzzRule> Rules { get; private set; } = [];

        public void AddRule(IFizzBuzzRule rule)
        {
            Rules.Add(rule);
        }

        public void ClearRules()
        {
            Rules.Clear();
        }

        public string FizzOrBuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            else if (i % 5 == 0)
                return "Buzz";
            else if (i % 3 == 0)
                return "Fizz";
            else
                return i.ToString();
        }

        private void DefaultRules()
        {
            Rules.Add(new FizzBuzzRule35());
            Rules.Add(new FizzBuzzRule("Fizz", 3));
            Rules.Add(new FizzBuzzRule("Buzz", 5));
        }
    }
}