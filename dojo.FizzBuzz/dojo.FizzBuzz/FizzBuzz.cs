namespace dojo.FizzBuzz
{
    public interface IFizzBuzz
    {
        string Parse(int i);
    }

    public class FizzBuzz : IFizzBuzz
    {
        internal string Parse(int i)
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
    }
}