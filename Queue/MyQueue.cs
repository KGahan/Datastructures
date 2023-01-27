using Common;

namespace Queue
{
    public class MyQueue : ISubject
    {

        private SingleLinkedList.SingleLinkedList myQueue = new SingleLinkedList.SingleLinkedList();
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public object Queue(object value)
        {
            myQueue.InsertLast(value);
            Notify();
            return value;
        }

        public Node Dequeue()
        {
            var nodeToDelete = myQueue.First();
            myQueue.DeleteNode(nodeToDelete);
            Notify();
            return nodeToDelete;
        }

        public override string ToString()
        {
            return myQueue.ToString();
        }
    }
}