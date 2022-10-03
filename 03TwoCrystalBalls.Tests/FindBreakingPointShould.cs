using _03TwoCrystalBalls;

namespace _03TwoCrystalBalls.Tests;

public class FindBreakingPointShould
{
    private TwoCrystalBalls _twoCrystalBalls;
    private Random _random;
    public FindBreakingPointShould()
    {
        _twoCrystalBalls = new TwoCrystalBalls();
        _random = new Random();
    }

    [Fact]
    public void FindBreakingPointShould_ReturnPoint()
    {
        // Arrange
        int expected = _random.Next(10001);
        bool[] data = new bool[10000];
        Array.Fill(data, false);

        for (int i = expected; i < 10000; i++)
        {
            data[i] = true;
        }

        // Act
        int actual = _twoCrystalBalls.FindBreakingPoint(data);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FindBreakingPointShould_ReturnNotFound()
    {
        // Arrange
        int expected = -1;
        bool[] data = new bool[10000];
        Array.Fill(data, false);

        // Act
        int actual = _twoCrystalBalls.FindBreakingPoint(data);

        // Assert
        Assert.Equal(expected, actual);
    }
}

