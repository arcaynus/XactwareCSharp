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
        [Test]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new SimpleCalculator();
            Assert.That(()=> sut.Divide(200,0), Throws.Exception);
        }
        [Test]
        public void ShouldErrorWhenDivideByZero_ExplicitExceptionType()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(50, 0), Throws.TypeOf<DivideByZeroException>());
        }
        [Test]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void ShouldErrorWhenNumberTooBig_MoreExplicit()
        {
            var sut = new SimpleCalculator();
            Assert.That(() => sut.Divide(200, 2),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Matches<ArgumentOutOfRangeException>(x=> x.ParamName == "value"));
        }



    }
}
