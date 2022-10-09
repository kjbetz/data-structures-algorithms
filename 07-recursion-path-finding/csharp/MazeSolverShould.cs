namespace _07PathFinder;

public class SolveShould_FindCorrectPath
{
    [Fact]
    public void Test1()
    {
        // Arrange
        string[] maze = new[]
        {
            "xxxxxxxxxx x",
            "x        x x",
            "x        x x",
            "x xxxxxxxx x",
            "x          x",
            "x xxxxxxxxxx",
        };

        Point[] expected = new []
        {
            new Point { x = 10, y = 0 },
            new Point { x = 10, y = 1 },
            new Point { x = 10, y = 2 },
            new Point { x = 10, y = 3 },
            new Point { x = 10, y = 4 },
            new Point { x = 9, y = 4 },
            new Point { x = 8, y = 4 },
            new Point { x = 7, y = 4 },
            new Point { x = 6, y = 4 },
            new Point { x = 5, y = 4 },
            new Point { x = 4, y = 4 },
            new Point { x = 3, y = 4 },
            new Point { x = 2, y = 4 },
            new Point { x = 1, y = 4 },
            new Point { x = 1, y = 5 }
        };
        
        // Act
        
        // Assert

    }

    public string DrawPath(string[] maze, Point[] path)
    {
        var data2 = maze.Select(row => row.Split(""));

        return "";
    }
}

