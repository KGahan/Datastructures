using Common;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class BubbleSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBubbleSort_RandomOrderOfElements_ReturnsCorrectOrder()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast(5);
            list.InsertLast(2);
            list.InsertLast(4);
            list.InsertLast(1);
            list.SetSortStrategy(new BubbleSort());
            list.Sort();

            Assert.AreEqual(list.head.data, 1);
            Assert.AreEqual(list.head.next.data, 2);
            Assert.AreEqual(list.head.next.next.data, 4);
            Assert.AreEqual(list.Last().data, 5);
        }
    }
}