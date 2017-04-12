using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit2_NameJoiner.Tests
{
    [TestFixture]
    public class NameJoinerTests
    {
        [Test]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("Brittany", "Snow");
            Assert.That(fullName, Is.EqualTo("Brittany Snow"));
        }

        [Test]
        public void ShouldJoinNames_CaseInsensitiveAssertDemo()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("doris", "chatterton");
            Assert.That(fullName, Is.EqualTo("DORIS CHATTERTON").IgnoreCase);
        }
        [Test]
        public void ShouldJoinNames_NotEqualDemo()
        {
            var sut = new NameJoiner();
            var fullName = sut.Join("Ryan", "Carter");
            Assert.That(fullName, Is.Not.EqualTo("Cortnet Dreiske"));
        }
    }
}
