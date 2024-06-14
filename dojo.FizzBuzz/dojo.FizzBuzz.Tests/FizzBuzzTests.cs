using dojo.FizzBuzz.Rules;
using FluentAssertions;

namespace dojo.FizzBuzz.Tests
{
    internal class FizzBuzzTests
    {
        [TestMethod]
        public void AddRuleTest1()
        {
            //arrange
            var uot = new FizzBuzz();
            //act
            uot.AddRule(new FizzBuzzRule("Fizz", 24));
            //assert
            uot.Rules.Count.Should().Be(4);
        }

        [TestMethod]
        public void AddRuleTest2()
        {
            //arrange
            var uot = new FizzBuzz();
            uot.ClearRules();
            //act
            uot.AddRule(new FizzBuzzRule("Moon", 24));
            //assert
            uot.Rules.Count.Should().Be(1);
            ((FizzBuzzRule)uot.Rules[0]).NumbersToDevideBy.Length.Should().Be(1);
            ((FizzBuzzRule)uot.Rules[0]).NumbersToDevideBy[0].Should().Be(24);
            ((FizzBuzzRule)uot.Rules[0]).FizzedWord.Should().Be("Moon");
        }

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

        [TestMethod]
        public void ClearRulesTest2()
        {
            //arrange
            var uot = new FizzBuzz();
            uot.AddRule(new FizzBuzzRule("Ping", 123));
            //act
            uot.ClearRules();
            //assert
            uot.Rules.Count.Should().Be(0);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            //arrange
            var uot = new FizzBuzz();
            //act

            //assert
            uot.Rules.Count.Should().Be(3);
        }

        [TestMethod]
        public void FizzBuzzInterfaceCheck()
        {
            // Arrange
            var uot = new FizzBuzz();

            // Act
            IFizzBuzz actual = uot as IFizzBuzz;
            // Assert
            actual.Should().NotBeNull($"Does not implement interface {nameof(IFizzBuzz)}!");
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(7, "7")]
        [DataRow(8, "8")]
        [DataRow(9, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(11, "11")]
        [DataRow(12, "Fizz")]
        [DataRow(13, "13")]
        [DataRow(14, "14")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(16, "16")]
        [DataRow(17, "17")]
        [DataRow(18, "Fizz")]
        [DataRow(19, "19")]
        [DataRow(20, "Buzz")]
        [DataRow(21, "Fizz")]
        [DataRow(22, "22")]
        public void FizzOrBuzz1(int numberToTest, string expected)
        {
            //arrange
            var uot = new FizzBuzz();
            //act
            var actual = uot.FizzOrBuzz(numberToTest);
            //assert
            uot.Rules.Count.Should().Be(3);
            actual.Should().Be(expected);
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(7, "Ping Pong")]
        [DataRow(8, "8")]
        [DataRow(9, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(11, "11")]
        [DataRow(12, "Fizz")]
        [DataRow(13, "13")]
        [DataRow(14, "Ping Pong")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(16, "16")]
        [DataRow(17, "17")]
        [DataRow(18, "Fizz")]
        [DataRow(19, "19")]
        [DataRow(20, "Buzz")]
        [DataRow(21, "Fizz")]
        [DataRow(22, "22")]
        public void FizzOrBuzz2(int numberToTest, string expected)
        {
            //arrange
            var uot = new FizzBuzz();
            uot.AddRule(new FizzBuzzRule("Ping Pong", 7));
            //act
            var actual = uot.FizzOrBuzz(numberToTest);
            //assert
            uot.Rules.Count.Should().Be(4);
            actual.Should().Be(expected);
        }
    }
}