public class TestLinkedList<T> : LinkedList<T>
{
    public override void Add(T item) 
    {
        if(head == null)
        {
            head = new LinkedListNode<T>(item, null, null);
        }
        else 
        {
            // add to end of list
            LinkedListNode<T> currentNode = head;
            while (currentNode.Next != null) {
                currentNode = currentNode.Next;
            }
            currentNode.Next = new LinkedListNode<T>(item, null, currentNode);
        }
        count++;
    }
}
