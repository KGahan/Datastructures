namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        public Node head;
        public int index = 0;

        public void InsertFirst(Object _value)
        {
            if(head == null)
            {
                head = new Node(_value);
                index++;
            }
            else
            {
                Node node = new Node(_value);
                node.next = head;
                head = node;
                index++;
            }
        }

        public void printAllNodes()
        {
            Node current = head;
            String printString = "";
            while (current != null)
            {
                printString += current.data + "\n";
                current = current.next;
            }
            Console.WriteLine(printString);
        }

        public void InsertLast(Object _value)
        {
            Node node = new Node(_value);

            if (head == null)
            { 
                head = node;
                index++;
            }
            else
            {
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                index++;
            }
        }


        public void DeleteAt(int _index)
        {
            if(_index > index)
            {
                Console.WriteLine("this Object doesn't exist");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }
                _next = previous.next.next;
                previous.next = _next;

            }
        }

        public void InsertAt(Object _value, int _index)
        {
            if (_index > index)
            {
                Console.WriteLine("this Object doesn't exist");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }
                Node newNode = new Node(_value);
                _next = previous.next;
                previous.next = newNode;
                newNode.next = _next;
                index++;
            }
        }

        public Node First()
        {
            return head;
        }

        public Node Last()
        {
            Node last = head;

            while(last.next != null)
            {
                last = last.next;
            }
            return last;
        }

        public int Count()
        {
            Node current = head;

            int count = 1;

            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
        public Node GetElement(Object element)
        {
            Node current = head;

            while (!current.data.Equals(element))
            {
                if(current.next == null) 
                {
                    Node node = new Node(null);
                    return node; 
                }

                current = current.next;  
            }
            return current;
        }
        public void InsertAfter(Object before, Object value)
        {
            Node node = new Node(value);
            Node getElement = GetElement(before);
            Node after = getElement.next;   

            getElement.next = node;
            getElement.next.next = after;
        }
        public bool DeleteNode(Node node)
        {
            Node current = head;
            Node next;
            int index = 0;

            while (!current.data.Equals(node.data))
            {
                if (current.next == null)
                {
                    return false;
                }
                current = current.next;
            }

            index++;
            DeleteAt(index);

            return true;
        }
        public bool Exists(Node node)
        {
            Node currentNode = head;
            if (currentNode == node) return true;
            while(currentNode != node)
            {
                 
                if (currentNode.next == node)
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }
        public override string ToString()
        {
            string retval = "";
            if (head == null)
                return "No elements in List";

            var node = head;
            while (node != null)
            {
                retval += "| " + node.data + " ";
                node = node.next;
            }
            retval += "|";
            return retval;
        }

        public void SwitchNodes(Node node1, Node node2)
        {
            if (!Exists(node1) || !Exists(node2)) return;

            (node1.data, node2.data) = (node2.data, node1.data);
        }

        public void RandomSort() //wrong sorting  system
        {
            Node current = head;
            int node1 = int.Parse(string.Format("{0}", current.data));
            int node2 = int.Parse(string.Format("{0}", current.next.data));

            while(current != null)
            {
                if (current.next == null) return;
                if(node1 > node2)
                {
                    current.data = node2;
                    current.next.data = node1;
                    current = head;
                }
                current = current.next;
                if (current.next == null) return;
                node1 = int.Parse(string.Format("{0}", current.data));
                node2 = int.Parse(string.Format("{0}", current.next.data));   
            }
        }

        public void InsertionSort()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var current = head; current != null; current = current.next)
                {
                    if (current == currentNode)
                        break;
                    if ((int)current.data < (int)currentNode.data)
                        continue;
                    (current.data, currentNode.data) = (currentNode.data, current.data);
                }
                currentNode = currentNode.next;
            }
        }

        public void InsertionSortReverse()
        {
            Node currentNode = head.next;
            while (currentNode != null)
            {
                for (var current = head; current != null; current = current.next)
                {
                    if (current == currentNode)
                        break;
                    if ((int)current.data > (int)currentNode.data)
                        continue;
                    (current.data, currentNode.data) = (currentNode.data, current.data);
                }
                currentNode = currentNode.next;
            }
        }
    }   
}