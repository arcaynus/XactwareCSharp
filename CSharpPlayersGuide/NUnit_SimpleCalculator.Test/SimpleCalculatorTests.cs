using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit1_SimpleCalculator;

namespace NUnit_SimpleCalculator.Test
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddInts(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldAddDoubles_WithTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddDoubles_WithPercentTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(50.0, 50.0);
            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }
        [Test]
        public void ShouldAddDoubles_WithBadTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(30).Within(100));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.MultiplyInts(2, 4);
            Assert.That(result, Is.EqualTo(8));
        }

        // Is.Positive
        // Is.Negative
        // Is.NaN

    }
}
