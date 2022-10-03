using _04BubbleSort;

namespace _04BubbleSort.Tests;

public class BubbleSortShould
{
    private BubbleSort _bubbleSort;
    public BubbleSortShould()
    {
        _bubbleSort = new BubbleSort();
    }

    [Fact]
    public void SortShouldSortArray()
    {
        // Arrange
        int[] arr = { 9, 3, 7, 4, 69, 420, 42 };
        int[] expected = { 3, 4, 7, 9, 42, 69, 420 };

        // Act
        int[] actual = _bubbleSort.Sort(arr);

        // Assert
        Assert.Equal(expected, actual);
    }
}

