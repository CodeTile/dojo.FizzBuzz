namespace dojo.FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            var fizzBuzz = new FizzBuzz();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz.Parse(i));
            }
        }
    }
}