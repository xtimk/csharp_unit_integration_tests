using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(15)]
        [TestCase(30)]
        public void GetOutput_NumberDivisibleBy3And5_ReturnFizzBuzzString(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
        }

        [Test]
        [TestCase(6)]
        [TestCase(9)]
        public void GetOutput_NumberDivisibleBy3Only_ReturnFizzString(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void GetOutput_NumberDivisibleBy5Only_ReturnBuzzString(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void GetOutput_NumberNotDivisibleBy3And5_ReturnSameNumber(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo(number.ToString()).IgnoreCase);
        }
    }
}
