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
            foreach (IFizzBuzzRule rule in Rules.OrderByDescending(m => m.NumbersToDevideBy.Length))
            {
                if (rule.Parse(i))
                    return rule.Result;
            }
            return i.ToString();
        }

        private void DefaultRules()
        {
            Rules.Add(new FizzBuzzRule("FizzBuzz", 3, 5));
            Rules.Add(new FizzBuzzRule("Fizz", 3));
            Rules.Add(new FizzBuzzRule("Buzz", 5));
        }
    }
}