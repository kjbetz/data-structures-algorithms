public class Stack<T>
{
    public int Length { get; set; }
    private Node<T> Head { get; set; }

    public void Push(T item)
    {
        Node<T> node = new(item);
        node.Next = this.Head;
        this.Head = node;
        this.Length++;
    }

    public T Pop()
    {
        Node<T> node = this.Head;
        this.Head = node.Next;
        this.Length--;
        return node.Value;
    }

    public T Peek()
    {
        return this.Head.Value;
    }
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T item)
    {
        Value = item;
    }
}

