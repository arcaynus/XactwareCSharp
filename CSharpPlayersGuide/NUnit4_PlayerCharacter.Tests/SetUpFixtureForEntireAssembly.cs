﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit4_PlayerCharacter.Tests
{
    class SetUpFixtureForEntireAssembly
    {
        [SetUpFixture]
        class SetUpFixtureForSpecificNameSpace
        {
            [OneTimeSetUp]
            public void RunBeforeAnyTestsInSomeNamespace()
            {
                TestContext.Progress.WriteLine($"!!!!! Before any tests in Assembly");
            }
            [OneTimeTearDown]
            public void RunAfterAnyTestsInSomeNamespace()
            {
                TestContext.Progress.WriteLine($"!!!!! After any tests in Assembly");
            }
        }
    }
}
