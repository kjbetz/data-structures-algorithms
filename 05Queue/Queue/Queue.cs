namespace _05Queue;

public class Queue<T>
{
    private QueueNode<T>? Head { get; set; }
    private QueueNode<T>? Tail { get; set; }
    public int Length { get; set; } = 0;

    public void Enqueue(T item)
    {
        QueueNode<T> node = new(item);

        if (this.Head == null) this.Head = node;
        if (this.Tail != null) this.Tail.Next = node;
        this.Tail = node;
        this.Length++;
    }

    public T Dequeue()
    {
        T value = this.Head!.Value;
        this.Head = this.Head?.Next;
        this.Length--;

        return value;
    }

    public T Peek()
    {
        return this.Head!.Value;
    }
}

public class QueueNode<T>
{
    public T Value { get; set; }
    public QueueNode<T>? Next { get; set; }

    public QueueNode(T value)
    {
        this.Value = value;
    }
}

