using Common;

class Programm
{
    static void Main(string[] args)
    {
        SingleLinkedList.SingleLinkedList singleLinkedList = new SingleLinkedList.SingleLinkedList();
        singleLinkedList.InsertFirst(2);
        singleLinkedList.InsertFirst(7);
        singleLinkedList.InsertFirst(2);
        singleLinkedList.InsertFirst(3);
        Console.WriteLine(singleLinkedList.ToString());

        singleLinkedList.SetSortStrategy(new BubbleSort());
        singleLinkedList.Sort();
        Console.WriteLine(singleLinkedList.ToString());    
    }
}
