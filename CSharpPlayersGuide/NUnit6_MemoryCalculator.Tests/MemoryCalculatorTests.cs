using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit6_MemoryCalculator.Tests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {

        MemoryCalculator sut;

        [SetUp]
        public void BeforeEachTest()
        {
            //Console.WriteLine($"Before {TestContext.CurrentContext.Test.Name}"); does not work
            TestContext.Progress.WriteLine($"Before {TestContext.CurrentContext.Test.Name}");
            sut = new MemoryCalculator();
        }

        
        [Test]
        public void ShouldAdd()
        {
            sut.Add(10);
            sut.Add(5);
            Assert.That(sut.CurrentValue, Is.EqualTo(15));
        }

        [Test]
        public void ShouldSubtrat()
        {
            sut.Subtract(5);
            Assert.That(sut.CurrentValue, Is.EqualTo(-5));
        }

        [TestCase(-5,-10,15)]
        [TestCase(-5, -5, 10)]
        [TestCase(-5, 0, 5)]
        public void ShouldSubtractTwoNegativeNumbers_Data1(int firstNum, int secondNum, int expectedNum)
        {
            sut.Subtract(firstNum);
            sut.Subtract(secondNum);
            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }

        [TestCaseSource(typeof(ExampleTestCaseSource))]
        public void ShouldSubtractTwoNegativeNumbers_Data2(int firstNum, int secondNum, int expectedNum)
        {
            sut.Subtract(firstNum);
            sut.Subtract(secondNum);
            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }

        [Test]
        [Ignore(reason: "Testing the Ignore Attribute")]
        [Category(name: "Long")]
        [MaxTime(4000)]
        [Repeat(100)]
        public void ShouldAddAndDivide([Values(10,20,30)] int numToAdd, [Values(2, 1, 10)]int numToDivide)
        {
            sut.Add(numToAdd);
            sut.Divide(numToDivide);
        }

        [TearDown]
        public void AfterEachTest()
        {
            TestContext.Progress.WriteLine($"After {TestContext.CurrentContext.Test.Name}");
            sut = null;
        }
    }

    public class ExampleTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] {-5, -10, 15};
            yield return new[] {-5, -5, 10};
            yield return new[] {-5, 0, 5};
        }
    }
}
