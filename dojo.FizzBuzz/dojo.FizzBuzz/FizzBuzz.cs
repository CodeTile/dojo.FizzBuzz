namespace dojo.FizzBuzz
{
    using dojo.FizzBuzz.Rules;

    public interface IFizzBuzz
    {
        void AddRule(IFizzBuzzRule rule);

        void ClearRules();

        void EnumerateRange(int min, int max);

        string FizzOrBuzz(int i);
    }

    public class FizzBuzz : IFizzBuzz
    {
        internal List<IFizzBuzzRule> Rules { get; private set; } = [];

        public static IFizzBuzz BuildFizzBuzzWithDefaultRules()
        {
            var target = new FizzBuzz
            {
                Rules = new List<IFizzBuzzRule>() { new FizzBuzzRule("FizzBuzz", 10, 3, 5), new FizzBuzzRule("Buzz", 20, 5), new FizzBuzzRule("Buzz", 30, 5), }
            };
            return target;
        }

        public void AddRule(IFizzBuzzRule rule)
        {
            Rules.Add(rule);
        }

        public void ClearRules()
        {
            Rules.Clear();
        }

        /// <summary>
        /// Check all numbers between minimum and maximum
        /// </summary>
        /// <param name="min">Starting number</param>
        /// <param name="max">Last number to check</param>
        public void EnumerateRange(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(FizzOrBuzz(i));
            }
        }

        public string FizzOrBuzz(int i)
        {
            foreach (var rule in from IFizzBuzzRule rule in Rules!.OrderBy(m => m.SortOrder)
                                 where rule.Matches(i)
                                 select rule)
            {
                if (rule != null)
                    return rule.Result;
            }

            return i.ToString();
        }
    }
}