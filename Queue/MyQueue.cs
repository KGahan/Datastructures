using Common;

namespace Queue
{
    public class MyStack
    {
        private SingleLinkedList.SingleLinkedList myQueue = new SingleLinkedList.SingleLinkedList();
        public object Queue(object value)
        {
            myQueue.InsertLast(value);
            return value;
        }

        public Node deQueue()
        {
            var nodeToDelete = myQueue.First();
            myQueue.DeleteNode(nodeToDelete);
            return nodeToDelete;
        }

        public override string ToString()
        {
            return myQueue.ToString();
        }
    }
}