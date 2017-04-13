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
            sut.Sleep();
            Assert.That(sut.Health, Is.InRange(101, 200));
        }

        // Also avaliable
        // Is.GreaterThanOrEqualTo();
        // Is.LessThan();
        // Is.LessThanOrEqualTo();

        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Name, Is.Not.Empty); //Is.Null, Is.Not.Null
        }

        [Test]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.NickName, Is.Null); //Is.Not.Null

        }

        [Test]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.IsNoob, Is.True); //Is.False

        }

        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveALongBow()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }

        [Test]
        public void ShouldHaveAShortBow()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Contains.Item("Short Bow"));
        }

        [Test]
        public void ShouldHaveAShortSword()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Contains.Item("Short Sword"));
        }

        [Test]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Some.Contains("Sword"));
        }

        [Test]
        public void ShouldHaveTwoBows()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Exactly(2).EndWith("Bow"));
        }

        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.Unique); //Basic string check
        }

        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.None.EqualTo("Staff of Wonder"));
        }

        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();
            var expectedWeapons = new[] {"Long Bow", "Short Sword", "Short Bow"};
            Assert.That(sut.Weapons, Is.EquivalentTo(expectedWeapons));
        }

        [Test]
        public void ShouldHaveDefaultWeaponsInAlphabeticalOrder()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.Ordered);
        }

        [Test]
        public void ReferenceEquality()
        {
            var player1 = new PlayerCharacter();
            var player2 = new PlayerCharacter();

            //Assert.That(player1, Is.SameAs(player2)); // Fails
            var somePlayer = player1;
            Assert.That(player1, Is.SameAs(somePlayer));
            Assert.That(player1, Is.Not.SameAs(player2));
        }
    }
}