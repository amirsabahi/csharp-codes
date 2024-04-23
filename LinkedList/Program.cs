// See https://aka.ms/new-console-template for more information
class Node
{
    public object Value;
    public Node Next;
    public Node(object value, Node? next)
    {
        Value = value;
        Next = next;
    }
}

class LinkedList
{
    private Node Head;
    public LinkedList()
    {
        Head = null;
    }
    public void Add(object value)
    {
        Node current = Head;
        if (Head == null)
        {
            Head = new Node(value, null);
        }
        else
        {
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(value, null);
        }
    }

    public void print()
    {
        Node current;
        while (Head != null)
        {
            current = Head;
            Head = current.Next;
            System.Console.WriteLine(current.Value);
        }
    }

}


public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(30);

        linkedList.print();
    }
}