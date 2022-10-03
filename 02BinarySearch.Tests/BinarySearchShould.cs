using _02BinarySearch;

namespace _02BinarySearch.Tests;

public class BinarySearchShould
{
    private readonly BinarySearch _binarySearch;
    public BinarySearchShould()
    {
        _binarySearch = new BinarySearch();
    }

    [Theory]
    [InlineData(69, true)]
    [InlineData(1336, false)]
    [InlineData(69420, true)]
    [InlineData(69421, false)]
    [InlineData(1, true)]
    [InlineData(0, false)]
    public void BinarySearch_ShouldCorrectlyIdentify(int value, bool expected)
    {
        // Arrange
        int[] nums = { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };

        // Act
        bool actual = _binarySearch.Search(nums, value); 

        // Assert
        Assert.Equal(expected, actual);
    }
}

