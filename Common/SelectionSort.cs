namespace Common
{
    public class SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            selectionSort(list, true);
        }

        public override void SortDesc(IMyList list)
        {
            selectionSort(list, false); 
        }

        private void selectionSort(IMyList list, bool asc)
        {
            var current = list.First();

            while (current.next != null)
            {
                var extreme = current;
                for (var cur = current.next; cur != null; cur = cur.next)
                {
                    if (asc)
                    {
                        if ((int)cur.data > (int)extreme.data)
                            continue;
                        extreme = cur;
                        break;
                    }
                    if ((int)cur.data < (int)extreme.data)
                        continue;
                    extreme = cur;
                }
                (extreme.data, current.data) = (current.data, extreme.data);
                current = current.next;
            }
            Console.WriteLine("SelectionSorted list");
        }
    }
}
