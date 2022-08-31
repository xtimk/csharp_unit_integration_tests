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
    public class DemeritPointCalculatorTests
    {
        // speedlimit is 65
        // maxDetectableSpeed is 300
        private DemeritPointsCalculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(0)]
        [TestCase(5)]
        [TestCase(20)]
        [TestCase(50)]
        [TestCase(65)]
        public void CalculateDemeritPoints_SpeedBelowLimit_ReturnZero(int speed)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(70,1)]
        [TestCase(72, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_SpeedHigherThanLimit_ReturnPoints(int speed, int expectedDemeritPoints)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedDemeritPoints));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        public void CalculateDemeritPoints_SpeedLtZero_RaiseArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => { _calculator.CalculateDemeritPoints(speed); }, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(301)]
        [TestCase(400)]

        public void CalculateDemeritPoints_SpeedGtMaxSpeed_RaiseArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => { _calculator.CalculateDemeritPoints(speed); }, Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
