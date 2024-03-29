﻿namespace Common
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (var cur = list.First(); cur.next != null; cur = cur.next)
                {
                    if (cur.next == null)
                        break;
                    if((int)cur.data > (int)cur.next.data)
                    {
                        (cur.data, cur.next.data) = (cur.next.data, cur.data);
                        sorted = false;
                    }
                }
            }
        }

        public override void SortDesc(IMyList list)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (var cur = list.First(); cur.next != null; cur = cur.next)
                {
                    if (cur.next == null)
                        break;
                    if ((int)cur.data < (int)cur.next.data)
                    {
                        (cur.data, cur.next.data) = (cur.next.data, cur.data);
                        sorted = false;
                    }
                }
            }
        }
    }
}