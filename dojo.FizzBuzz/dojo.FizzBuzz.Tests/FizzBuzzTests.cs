using FluentAssertions;

namespace dojo.FizzBuzz.Tests
{
    internal class FizzBuzzTests
    {
        [TestMethod]
        public void ClearRulesTest1()
        {
            //arrange
            var uot = new FizzBuzz();
            //act
            uot.ClearRules();
            //assert
            uot.Rules.Count.Should().Be(0);
        }
    }
}