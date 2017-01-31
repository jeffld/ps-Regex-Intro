using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexIntro.Tests
{
    [TestClass()]
    public class TestRegexMatch
    {

        [TestMethod()]
        public void SimpleMatch()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat";
            RegexIntro.Subject = "cat";
            var expected = true;

            // Act
            var actual = RegexIntro.MatchTest();
            
            // Assert
            Assert.AreEqual(expected, actual);
        }






    }

}
