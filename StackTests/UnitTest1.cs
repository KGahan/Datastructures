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

        [Test]
        public void CheckStringMirrored_ValidMirroredString_ReturnsTrue()
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            var stringMirrored = new StringMirrored(stack1, stack2);

            int result = stringMirrored.stringMirrored("brot", "torb");

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CheckStringMirrored_InvalidMirroredString_ReturnsFalse()
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();
            var stringMirrored = new StringMirrored(stack1, stack2);

            int result = stringMirrored.stringMirrored("apfel", "birne");

            Assert.AreEqual(result, 1);
        }
    }
}