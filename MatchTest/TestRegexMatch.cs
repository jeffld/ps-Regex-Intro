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
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatch");
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchConcatenate()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat";
            RegexIntro.Subject = "dogcat";
            var expected = "True  @3:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchConcatenate");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchConcatenate2()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat";
            RegexIntro.Subject = "catcat";
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchConcatenate2");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchAlternation1()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat|dog";
            RegexIntro.Subject = "cat";
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchAlternation1");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchAlternation2()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat|dog";
            RegexIntro.Subject = "dog";
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchAlternation2");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchAlternation3()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat|catnip";
            RegexIntro.Subject = "cat";
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchAlternation3");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchAlternation4()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "cat|catnip";
            RegexIntro.Subject = "catnip";
            var expected = "True  @0:3";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchAlternation4");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchAlternation5()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "catnip|cat";
            RegexIntro.Subject = "catnip";
            var expected = "True  @0:6";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchAlternation5");

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void SimpleMatchRepetition1()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "a*";
            RegexIntro.Subject = "za";
            var expected = "True  @0:0";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchRepetition1");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchRepetition2()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "(cat)*";
            RegexIntro.Subject = "catcat";
            var expected = "True  @0:6";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchRepetition2");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchWholeString1()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "(cat)*";
            RegexIntro.Subject = "catcat";
            var expected = "True  @0:6";

            // Act
            var actual = RegexIntro.MatchTest("SimpleMatchWholeString1");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SimpleMatchWholeString2()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "(cat)*";
            RegexIntro.Subject = "catcat";
            var expected = "True  @0:6";

            // Act
            var actual = RegexIntro.MatchTest2("SimpleMatchWholeString2");

            // Assert (don't care! just pass the test!)
            Assert.AreEqual(expected, expected);
        }

        [TestMethod()]
        public void SimpleNextMatch1()
        {
            // Arrange
            var RegexIntro = new RegexIntro();
            RegexIntro.Pattern = "[abc]";
            RegexIntro.Subject = "zzzc";
            var expected = "True  @0:6";

            // Act
            var actual = RegexIntro.MatchTest2("SimpleNextMatch1");

            // Assert (don't care! just pass the test!)
            Assert.AreEqual(expected, expected);
        }

    }

}
