namespace _07PathFinder;

public class MazeSolverShould
{
    private MazeSolver _mazeSolver;
    public MazeSolverShould()
    {
        _mazeSolver = new MazeSolver();
    }

    [Fact]
    public void SolveShould_FindCorrectPath()
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
            new Point(10, 0),
            new Point(10, 1),
            new Point(10, 2),
            new Point(10, 3),
            new Point(10, 4),
            new Point(9, 4),
            new Point(8, 4),
            new Point(7, 4),
            new Point(6, 4),
            new Point(5, 4),
            new Point(4, 4),
            new Point(3, 4),
            new Point(2, 4),
            new Point(1, 4),
            new Point(1, 5) 
        };
        
        // Act
        Point[] actual = _mazeSolver.Solve(maze, "x", new Point(10, 0), new Point(1, 5));

        string[] expectedDrawn = DrawPath(maze, expected); 
        string[] actualDrawn = DrawPath(maze, actual);
        Console.WriteLine("EXPECTED");

        for (int i = 0; i < expectedDrawn.Length; ++i)
        {
            Console.WriteLine(expectedDrawn[i]);
        }
        Console.WriteLine("ACTUAL");

        for (int i = 0; i < actualDrawn.Length; ++i)
        {
            Console.WriteLine(actualDrawn[i]);
        }

        // Assert
        Assert.Equal(DrawPath(maze, expected), DrawPath(maze, actual));
    }

    public string[] DrawPath(string[] maze, Point[] path)
    {
        char[][] data2 = maze.Select(row => row.ToCharArray()).ToArray();

        for(int i = 0; i < path.Length; ++i)
        {
            if (data2[path[i].y] != null && data2[path[i].y][path[i].x] != null)
            {
                data2[path[i].y][path[i].x] = '*';
            }
        }

        var result = data2.Select(row => String.Join("", row)).ToArray();

        return result;
    }
}

