﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.First().next;

            while (nextNode != null)
            {
                for (var cur = list.First(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if ((int)cur.data < (int)nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }

        public override void SortDesc(IMyList list)
        {
            var nextNode = list.First().next;

            while (nextNode != null)
            {
                for (var cur = list.First(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if ((int)cur.data > (int)nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }
}
