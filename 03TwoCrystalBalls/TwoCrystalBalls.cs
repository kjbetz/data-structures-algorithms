namespace _03TwoCrystalBalls;

public class TwoCrystalBalls
{
    public int FindBreakingPoint(bool[] breaks)
    {
        int jump = (int)Math.Floor(Math.Sqrt(breaks.Length));
        int i = jump;

        for (; i < breaks.Length; i += jump)
        {
            if (breaks[i] == true) break;
        }

        i -= jump;

        for (int j = 0; j < jump && i < breaks.Length; i++)
        {
            if (breaks[i] == true) return i;
        }

        return -1;
    }
}

