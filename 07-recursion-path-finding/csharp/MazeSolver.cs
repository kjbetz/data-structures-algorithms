namespace _07PathFinder;

public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class MazeSolver
{
    public Point[] Solve(
        string[] maze,
        string wallChar, 
        Point startPoint, 
        Point endPoint)
    {
        Stack<Point> path = new();
        bool[,] visited = new bool[6, 11];

        for(int i = 0; i < 5; ++i)
        {
            for(int j = 0; j < 10; ++j)
            {
                visited[i, j] = false;
            }
        }

        Walk(maze, 'x', startPoint, endPoint, visited, path);

        return path.ToArray();
    }

    public bool Walk(
            string[] maze,
            char wall, 
            Point currentPoint, 
            Point endPoint, 
            bool[,] visited, 
            Stack<Point> path)
    {
        Point[] direction = new[] {
            new Point(-1, 0),
            new Point(0, 1),
            new Point(-1, 1),
            new Point(1, 1)
        };

        // Base Case 1. Off the map
        if (currentPoint.x < 0 || currentPoint.x >= maze[0].Length ||
                currentPoint.y < 0 || currentPoint.y >= maze.Length)
        {
            return false;
        }

        // Base Case 2. On a wall
        if (maze[currentPoint.y][currentPoint.x] == wall)
        {
            return false;
        }

        // Base Case 3. At end
        if (currentPoint.x == endPoint.x && currentPoint.y == endPoint.y)
        {
            path.Push(currentPoint);
            return true;
        }

        // Base Case 4. Already visited
        if (visited[currentPoint.y, currentPoint.x] == true)
        {
            return false;
        }


        // Recursion 3 stages
        // Pre
        visited[currentPoint.y, currentPoint.x] = true;
        path.Push(currentPoint);


        // Recurse
        for (int i = 0; i < direction.Length; ++i)
        {
            Point nextPoint = new (currentPoint.x + direction[i].x, currentPoint.y + direction[i].y);

            if (Walk(maze, wall, nextPoint, endPoint, visited, path) == true)
            {
                return true;
            }
        }

        // Post
        path.Pop();
        return false;
    }
}

