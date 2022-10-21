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
        public void TestLinkedListCount_AddItems_ReturnsCorrectCount()
        {
            SingleLinkedList.SingleLinkedList list= new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedListInsertFirst_AddItems_ReturnsCorrectNumberOfElements()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedList_InsertLast_ReturnsCorrectLastElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            Assert.AreEqual(7, list.Last().data);
        }

        [Test]
        public void TestLinkedListInserAfter_AddItems_ReturnsCorrectOrderdList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertAfter(2, 7);
            object current = list.First();
            Assert.AreEqual(7, list.First().next.next.data);
        }

        [Test]
        public void TestLinkedList_GetNode_ReturnsCorrectDataOfElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(2, list.GetElement(2).data);
        }

        [Test]
        public void TestLinkedList_DeleteNode_ReturnsCorrectNumberOfElements()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            list.DeleteNode(list.GetElement(3));
            Assert.AreEqual(3, list.Count());
        }
    }
}