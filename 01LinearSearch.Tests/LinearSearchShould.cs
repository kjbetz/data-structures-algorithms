using _01LinearSearch;

namespace _01LinearSearch.Tests;

public class LinearSearchShould
{
    private readonly LinearSearch _linearSearch;
    public LinearSearchShould()
    {
        _linearSearch = new LinearSearch();
    }

    [Theory]
    [InlineData(69, true)]
    [InlineData(1336, false)]
    [InlineData(69420, true)]
    [InlineData(69421, false)]
    [InlineData(1, true)]
    [InlineData(0, false)]
    public void LinearSearch_ShouldCorrectlyIdentify(int value, bool expected)
    {
        // Arrange
        int[] nums = { 1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420 };

        // Act
        bool actual = _linearSearch.Search(nums, value); 

        // Assert
        Assert.Equal(expected, actual);
    }
}
    
