﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Specific assertion
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            // More general. This can still be passing also with a wrong function impl.
            //Assert.That(result, Does.StartWith("<strong>"));
            //Assert.That(result, Does.EndWith("</strong>"));
            //Assert.That(result, Does.Contain("abc"));


        }
    }
}
