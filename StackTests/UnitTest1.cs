using NUnit.Framework;
using Stack;
using System.Collections.Generic;

namespace StackTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckPalindrom_ValidPalindrom_ReturnsTrue()
        {
            Stack<char> stack = new Stack<char>();
            var palindrom = new Palindrom(stack);

            bool result = palindrom.checkPalindrom("anna");

            Assert.IsTrue(result);
        }

        [Test]
        public void CheckPalindrom_InvalidPalindrom_ReturnsFalse()
        {
            Stack<char> stack = new Stack<char>();
            var palindrom = new Palindrom(stack);

            bool result = palindrom.checkPalindrom("hello");

            Assert.IsFalse(result);
        }
    }
}