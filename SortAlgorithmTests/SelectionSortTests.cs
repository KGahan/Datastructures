using Common;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class SelectionSortedTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSelectionSortAsc_RandomOrderOfElements_ReturnsCorrectOrder()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast(1);
            list.InsertLast(5);
            list.InsertLast(2);
            list.InsertLast(4);
            list.SetSortStrategy(new SelectionSort());
            list.Sort();

            Assert.AreEqual(list.head.data, 1);
            Assert.AreEqual(list.head.next.data, 2);
            Assert.AreEqual(list.head.next.next.data, 4);
            Assert.AreEqual(list.Last().data, 5);
        }

        [Test]
        public void TestSelectionSortDesc_RandomOrderOfElements_ReturnsCorrectOrder()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast(1);
            list.InsertLast(5);
            list.InsertLast(2);
            list.InsertLast(4);
            list.SetSortStrategy(new SelectionSort());
            list.SortDesc();

            Assert.AreEqual(list.head.data, 5);
            Assert.AreEqual(list.head.next.data, 4);
            Assert.AreEqual(list.head.next.next.data, 2);
            Assert.AreEqual(list.Last().data, 1);
        }
    }
}