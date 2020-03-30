public class LinkedListNode<T>
{
    T value;
    LinkedListNode<T> next;
    LinkedListNode<T> previous;

    public LinkedListNode(T value, LinkedListNode<T> next, LinkedListNode<T> previous) 
    {
        this.value = value;
        this.next = next;
        this.previous = previous;
    }

    public LinkedListNode<T> Next {
        get{return next;}
        set{next = value;}
    }

    public LinkedListNode<T> Previous{
        get {return previous; }
        set {previous = value;}
    }

    public T Value{
        get {return value; }
    }
}
