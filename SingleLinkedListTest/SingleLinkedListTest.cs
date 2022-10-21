using NUnit.Framework;
using SingleLinkedList;
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

        [Test]
        public void TestLinkedList_SwitchItems_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Node? node1 = list.GetElement(3);
            Node? node2 = list.GetElement(1);
            list.SwitchNodes(node1, node2);

            Assert.AreEqual(1, list.head.data);
        }

        [Test]
        public void TestLinkedList_SwitchItems_ReturnsFalseList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Node? node1 = list.GetElement(3);
            Node? node2 = list.GetElement(1);
           
            Assert.AreEqual("Second Node doesn't exist!", list.SwitchNodes(node1, node2));
            list.printAllNodes();
        }
    }
}