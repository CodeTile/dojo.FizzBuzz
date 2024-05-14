namespace dojo.FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            IFizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz.FizzOrBuzz(i));
            }
        }
    }
}