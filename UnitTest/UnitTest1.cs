using NUnit.Framework;
using Stack;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CustomStack<int> stack = new CustomStack<int>();
            Assert.AreEqual(stack.size(), 0);
            stack.Push(1);
            Assert.AreEqual(stack.size(), 1);
            Assert.Pass();
        }

        [Test]
        public void TestLinkedList_AddItems_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list= new SingleLinkedList.SingleLinkedList();

        }
    }
}