namespace dojo.FizzBuzz.Rules
{
    public interface IFizzBuzzRule
    {
        string Result { get; }

        bool Parse(int i);
    }
}