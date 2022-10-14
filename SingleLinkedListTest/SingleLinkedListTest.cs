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
        public void TestLinkedList_CountItems_ReturnsCorrectNumberOfElements()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedList_InsertAfter_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertAfter(2, 7);
            object current = list.First();
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedList_InsertFirst_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.First());
        }

        [Test]
        public void TestLinkedList_InsertLast_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            Assert.AreEqual(7, list.Last());
        }

        /*[Test]
        public void TestLinkedList_GetNode_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            //Assert.AreEqual(8, list.GetElement(8).data);
        }*/

        [Test]
        public void TestLinkedList_DeleteNode_ReturnsCorrectList()
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