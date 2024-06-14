namespace dojo.FizzBuzz.Tests
{
    using dojo.FizzBuzz.Rules;
    using FluentAssertions;

    [TestClass]
    public class FizzBuzzRuleTests
    {
        [TestMethod]
        [DataRow(-3, true, "Fizz")]
        [DataRow(-1, false, "-1")]
        [DataRow(0, false, "0")]
        [DataRow(1, false, "1")]
        [DataRow(2, false, "2")]
        [DataRow(3, true, "Fizz")]
        [DataRow(4, false, "4")]
        [DataRow(5, false, "5")]
        [DataRow(6, true, "Fizz")]
        [DataRow(7, false, "7")]
        [DataRow(14, false, "14")]
        [DataRow(15, true, "Fizz")]
        [DataRow(16, false, "16")]
        public void FizzBuzzRule3(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Fizz", 1, 3);

            // Act
            var parsed = uot.Matches(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [TestMethod]
        [DataRow(-15, true, "FizzBuzz")]
        [DataRow(0, false, "0")]
        [DataRow(1, false, "1")]
        [DataRow(2, false, "2")]
        [DataRow(3, false, "3")]
        [DataRow(4, false, "4")]
        [DataRow(5, false, "5")]
        [DataRow(6, false, "6")]
        [DataRow(7, false, "7")]
        [DataRow(8, false, "8")]
        [DataRow(13, false, "13")]
        [DataRow(14, false, "14")]
        [DataRow(15, true, "FizzBuzz")]
        [DataRow(20, false, "20")]
        [DataRow(21, false, "21")]
        [DataRow(22, false, "22")]
        [DataRow(30, true, "FizzBuzz")]
        public void FizzBuzzRule35(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("FizzBuzz", 1, 3, 5);

            // Act
            var parsed = uot.Matches(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [TestMethod]
        [DataRow(1, false, "1")]
        [DataRow(2, false, "2")]
        [DataRow(3, false, "3")]
        [DataRow(4, false, "4")]
        [DataRow(5, true, "Buzz")]
        [DataRow(6, false, "6")]
        [DataRow(7, false, "7")]
        [DataRow(14, false, "14")]
        [DataRow(15, true, "Buzz")]
        [DataRow(16, false, "16")]
        public void FizzBuzzRule5(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Buzz", 1, 5);

            // Act
            var parsed = uot.Matches(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [TestMethod]
        [DataRow(1, false, "1")]
        [DataRow(2, false, "2")]
        [DataRow(3, false, "3")]
        [DataRow(4, false, "4")]
        [DataRow(5, false, "5")]
        [DataRow(6, false, "6")]
        [DataRow(7, true, "Ping Pong")]
        [DataRow(8, false, "8")]
        [DataRow(13, false, "13")]
        [DataRow(14, true, "Ping Pong")]
        [DataRow(15, false, "15")]
        [DataRow(20, false, "20")]
        [DataRow(21, true, "Ping Pong")]
        [DataRow(22, false, "22")]
        public void FizzBuzzRule7(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Ping Pong", 1, 7);

            // Act
            var parsed = uot.Matches(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [TestMethod]
        public void FizzBuzzRuleTypeCheck()
        {
            // Arrange
            var uot = new FizzBuzzRule("Fizz", 3);

            // Act
            IFizzBuzzRule actual = uot as IFizzBuzzRule;
            // Assert
            actual.Should().NotBeNull($"Does not implement interface {nameof(IFizzBuzzRule)}!");
        }
    }
}