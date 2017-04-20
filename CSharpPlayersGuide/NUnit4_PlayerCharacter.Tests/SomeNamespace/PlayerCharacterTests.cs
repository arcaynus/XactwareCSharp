using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit4_PlayerCharacter.Tests.SomeNamespace
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        private PlayerCharacter sut;

        [OneTimeSetUp]
        public void BeforeAnyTestsStarted()
        {
            TestContext.Progress.WriteLine($"Before any Tests Runs, Before Setup");
        }
        [OneTimeTearDown]
        public void AfterAllTestsComplete()
        {
            TestContext.Progress.WriteLine($"After all Tests Runs, After last Teardown");
        }

        [SetUp]
        public void BeforeEachTest()
        {
            TestContext.Progress.WriteLine($"Before {TestContext.CurrentContext.Test.Name}");
            sut = new PlayerCharacter();
        }

        [TearDown]
        public void AfterEachTest()
        {
            TestContext.Progress.WriteLine($"After {TestContext.CurrentContext.Test.Name}");
            sut = null;
        }

        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            sut.Health = 100;
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
        }

        [Test]
        public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
        {
            sut.Health = 100;
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
            Assert.That(sut.Name, Is.Not.Empty); //Is.Null, Is.Not.Null
        }

        [Test]
        public void ShouldNotHaveANickName()
        {
           
            Assert.That(sut.NickName, Is.Null); //Is.Not.Null

        }

        [Test]
        public void ShouldBeNewbie()
        {
      
            Assert.That(sut.IsNoob, Is.True); //Is.False

        }

        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
       
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
          
            Assert.That(sut.Weapons, Contains.Item("Short Bow"));
        }

        [Test]
        public void ShouldHaveAShortSword()
        {
          
            Assert.That(sut.Weapons, Contains.Item("Short Sword"));
        }

        [Test]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            
            Assert.That(sut.Weapons, Has.Some.Contains("Sword"));
        }

        [Test]
        public void ShouldHaveTwoBows()
        {
          
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
          
            Assert.That(sut.Weapons, Has.None.EqualTo("Staff of Wonder"));
        }

        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
         
            var expectedWeapons = new[] {"Long Bow", "Short Sword", "Short Bow"};
            Assert.That(sut.Weapons, Is.EquivalentTo(expectedWeapons));
        }

        [Test]
        public void ShouldHaveDefaultWeaponsInAlphabeticalOrder()
        {
          
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