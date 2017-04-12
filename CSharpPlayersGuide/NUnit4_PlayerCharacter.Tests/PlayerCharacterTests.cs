using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit4_PlayerCharacter.Tests
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter {Health = 100};
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
        }

        [Test]
        public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
        {
            var sut = new PlayerCharacter {Health = 100};
            
        }


    }
}
