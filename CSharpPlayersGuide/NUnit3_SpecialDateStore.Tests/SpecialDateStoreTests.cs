using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit3_SpecialDateStore.Tests
{
    [TestFixture]
    public class SpecialDateStoreTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDateStore.SpecialDates.NewMillennium);
            Assert.That(result, Is.EqualTo(new DateTime(2000,1,1,0,0,0)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDateStore.SpecialDates.NewMillennium);
            //Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1))); // Will Fail due to being 1 millisecond off
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);
        }
    }
}
