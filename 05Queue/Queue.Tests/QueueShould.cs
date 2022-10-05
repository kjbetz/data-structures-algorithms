using _05Queue;

namespace _05Queue.Tests;

public class QueueShould
{
    private Queue<int> _queue;
    public QueueShould()
    {
        _queue = new Queue<int>();
    }

    [Fact]
    public void EnqueueShouldAddItems()
    {
        // Arrange
        _queue.Enqueue(5);
        _queue.Enqueue(7);
        _queue.Enqueue(9);

        int? expected = 3;

        // Act
        int? actual = _queue.Length;

        // Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void DequeueShouldRemoveItem()
    {
        // Arrange
        _queue.Enqueue(5);
        _queue.Enqueue(7);
        _queue.Enqueue(9);

        int? expected = 5;
        int expectedLength = 2;

        // Act
        int? actual = _queue.Dequeue();
        int actualLength = _queue.Length;

        // Assert
        Assert.Equal(expected, actual);
        Assert.Equal(expectedLength, actualLength);
    }

    [Fact]
    public void PeekShouldReturnFirstItem()
    {
        // Arrange
        _queue.Enqueue(5);
        _queue.Enqueue(7);
        _queue.Enqueue(9);
        _queue.Dequeue();

        int? expected = 7;

        // Act
        int? actual = _queue.Peek();

        // Assert
        Assert.Equal(expected, actual);
    }
}

