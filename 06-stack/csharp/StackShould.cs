public class StackShould
{
    private Stack<int> _stack;
    public StackShould()
    {
        _stack = new();
    }

    [Fact]
    public void PushShould_AddItem()
    {
        // Arrange
        _stack.Push(5);
        _stack.Push(7);
        _stack.Push(9);

        int expectedLength = 3;
        int expectedPeekValue = 9;
        
        // Act
        int actualLength = _stack.Length;
        int actualPeekValue = _stack.Peek();

        // Assert
        Assert.Equal(expectedLength, actualLength);
        Assert.Equal(expectedPeekValue, actualPeekValue);
    }

    [Fact]
    public void PopShould_RemoveItem()
    {
        // Arrange
        _stack.Push(5);
        _stack.Push(7);
        _stack.Push(9);

        int expectedBeforePopPeekValue = 9;
        int expectedBeforePopLength = 3;
        int expectedPopValue = 9;
        int expectedAfterPopPeekValue = 7;
        int expectedAfterPopLength = 2;
        
        // Act
        int actualBeforePopPeekValue = _stack.Peek();
        int actualBeforePopLength = _stack.Length;
        int actualPopValue = _stack.Pop();
        int actualAfterPopPeekValue = _stack.Peek();
        int actualAfterPopLength = _stack.Length;

        // Assert
        Assert.Equal(expectedBeforePopPeekValue, actualBeforePopPeekValue);
        Assert.Equal(expectedBeforePopLength, actualBeforePopLength);
        Assert.Equal(expectedPopValue, actualPopValue);
        Assert.Equal(expectedAfterPopPeekValue, actualAfterPopPeekValue);
        Assert.Equal(expectedAfterPopLength, actualAfterPopLength);

    }

    [Fact]
    public void PeepShould_DisplayItem()
    {
        // Arrange
        _stack.Push(5);
        _stack.Push(7);
        _stack.Push(9);

        int expected = 9;
        
        // Act
        int actual = _stack.Peek();


        // Assert
        Assert.Equal(expected, actual);
    }
}

