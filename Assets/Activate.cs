using UnityEngine;

public class Activate : MonoBehaviour
{
    LinkedList<string> list = new TestLinkedList<string>();
    public void OutputLinkedList()
    {
        LinkedListNode<string> currentNode = list.Head;
        int nodeCount = 0;
        while (currentNode != null)
        {
            nodeCount++;
            Debug.Log(currentNode.Value);
            currentNode = currentNode.Next;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        list.Add("Foxtrot");
        list.Add("item2");
        for(int i=0; i<500; i++) {
            string s = "A Random Number: " + Random.Range(1,10);
            list.Add(s);
        }
        Debug.Log("TestAddEmptyLinkedList: ");
        OutputLinkedList();
    }
}
