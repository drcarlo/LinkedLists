abstract public class LinkedList<T>
{
    protected LinkedListNode<T> head;
    protected int count;
    protected LinkedList()
    {
        head = null;
        count = 0;
    }

    public int Count {
        get {return count;}
    }

    public LinkedListNode<T> Head 
    {
        get {return head; }
    }

    public abstract void Add(T item);

    public void Clear()
    {
        if(head != null)
        {
            LinkedListNode<T> previousNode = head;
            LinkedListNode<T> currentNode = head.Next;
            previousNode.Next = null;
            while(currentNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                previousNode.Next = null;
                previousNode.Previous = null;
            }
        }
        head = null;
        count = 0;
    }

    public bool Remove(T item)
    {
        if(head == null) return false;
        else if(head.Value.Equals(item))
        {
            if(head.Next != null)
            {
                head.Next.Previous = null;
            }
            head = head.Next;
            count--;
            return true;
        }
        else
        {
            LinkedListNode<T> currentNode = head.Next;
            while(currentNode != null && !currentNode.Value.Equals(item))
            {
                currentNode = currentNode.Next;
            }
            if(currentNode == null)
            {
                return false;
            }
            else
            {
                currentNode.Previous.Next = currentNode.Next;
                count--;
                return true;
            }
        }
    }

    public LinkedListNode<T> Find(T item)
    {
        LinkedListNode<T> currentNode = head;
        while (currentNode != null && !currentNode.Value.Equals(item))
        {   
            currentNode = currentNode.Next;
        }
        if (currentNode != null)
        {
            return currentNode;
        }
        else{return null;}
    }
}
