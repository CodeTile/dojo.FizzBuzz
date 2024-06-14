namespace dojo.FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            IFizzBuzz target = FizzBuzz.BuildFizzBuzzWithDefaultRules();
            target.EnumerateRange(0, 100);
        }
    }
}