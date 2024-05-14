namespace dojo.FizzBuzz.Tests.nUnit
{
    using dojo.FizzBuzz.Rules;
    using FluentAssertions;

    public class FizzBuzzRuleTests
    {
        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(-3, true, "Fizz")]
        [TestCase(3, true, "Fizz")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, true, "Fizz")]
        [TestCase(7, false, "7")]
        [TestCase(14, false, "14")]
        [TestCase(15, true, "Fizz")]
        [TestCase(16, false, "16")]
        public void FizzBuzzRule3(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Fizz", 3);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, false, "6")]
        [TestCase(7, false, "7")]
        [TestCase(8, false, "8")]
        [TestCase(13, false, "13")]
        [TestCase(14, false, "14")]
        [TestCase(-15, true, "FizzBuzz")]
        [TestCase(15, true, "FizzBuzz")]
        [TestCase(20, false, "20")]
        [TestCase(21, false, "21")]
        [TestCase(22, false, "22")]
        [TestCase(30, true, "FizzBuzz")]
        [TestCase(-30, true, "FizzBuzz")]
        public void FizzBuzzRule35(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("FizzBuzz", 3, 5);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, true, "Buzz")]
        [TestCase(6, false, "6")]
        [TestCase(7, false, "7")]
        [TestCase(14, false, "14")]
        [TestCase(15, true, "Buzz")]
        [TestCase(16, false, "16")]
        public void FizzBuzzRule5(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Buzz", 5);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, false, "6")]
        [TestCase(7, true, "Ping Pong")]
        [TestCase(8, false, "8")]
        [TestCase(13, false, "13")]
        [TestCase(14, true, "Ping Pong")]
        [TestCase(15, false, "15")]
        [TestCase(20, false, "20")]
        [TestCase(21, true, "Ping Pong")]
        [TestCase(22, false, "22")]
        public void FizzBuzzRule7(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Ping Pong", 7);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }
    }

    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(-3, true, "Fizz")]
        [TestCase(3, true, "Fizz")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, true, "Fizz")]
        [TestCase(7, false, "7")]
        [TestCase(14, false, "14")]
        [TestCase(15, true, "Fizz")]
        [TestCase(16, false, "16")]
        public void FizzBuzzRule3(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Fizz", 3);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, false, "6")]
        [TestCase(7, false, "7")]
        [TestCase(8, false, "8")]
        [TestCase(13, false, "13")]
        [TestCase(14, false, "14")]
        [TestCase(-15, true, "FizzBuzz")]
        [TestCase(15, true, "FizzBuzz")]
        [TestCase(20, false, "20")]
        [TestCase(21, false, "21")]
        [TestCase(22, false, "22")]
        [TestCase(30, true, "FizzBuzz")]
        [TestCase(-30, true, "FizzBuzz")]
        public void FizzBuzzRule35(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("FizzBuzz", 3, 5);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, true, "Buzz")]
        [TestCase(6, false, "6")]
        [TestCase(7, false, "7")]
        [TestCase(14, false, "14")]
        [TestCase(15, true, "Buzz")]
        [TestCase(16, false, "16")]
        public void FizzBuzzRule5(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Buzz", 5);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }

        [Test]
        [TestCase(0, false, "0")]
        [TestCase(1, false, "1")]
        [TestCase(2, false, "2")]
        [TestCase(3, false, "3")]
        [TestCase(4, false, "4")]
        [TestCase(5, false, "5")]
        [TestCase(6, false, "6")]
        [TestCase(7, true, "Ping Pong")]
        [TestCase(8, false, "8")]
        [TestCase(13, false, "13")]
        [TestCase(14, true, "Ping Pong")]
        [TestCase(15, false, "15")]
        [TestCase(20, false, "20")]
        [TestCase(21, true, "Ping Pong")]
        [TestCase(22, false, "22")]
        public void FizzBuzzRule7(int value, bool parsedExpected, string resultExpected)
        {
            // Arrange
            var uot = new FizzBuzzRule("Ping Pong", 7);

            // Act
            var parsed = uot.Parse(value);
            // Assert
            parsed.Should().Be(parsedExpected);
            uot.Result.Should().Be(resultExpected);
        }
    }
}