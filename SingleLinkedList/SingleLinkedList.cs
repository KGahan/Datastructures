﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class SingleLinkedList
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

        public object First()
        {
            return head.data;
        }

        public object Last()
        {
            Node last = head;

            while(last.next != null)
            {
                last = last.next;
            }

            return last.data;
        }
    }   
}