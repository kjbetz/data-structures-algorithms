namespace _03TwoCrystalBalls;

public class TwoCrystalBalls
{
    public int FindBreakingPoint(bool[] breaks)
    {
        int jump = (int)Math.Floor(Math.Sqrt(breaks.Length));
        int checkpoint = jump;
        int lastKnown = -1;
        bool walkIt = false;

        do
        {
            if (breaks[checkpoint] == false)
            {
                lastKnown = checkpoint;
                checkpoint = walkIt == true ? checkpoint + 1 : checkpoint + jump;
            }
            else
            {
                if (walkIt == false)
                {
                    checkpoint = lastKnown == -1 ? 0 : lastKnown;
                    walkIt = true;
                }
                else
                {
                    break;
                }
            }
        } while (checkpoint < breaks.Length);

        return checkpoint >= breaks.Length ? -1 : checkpoint;
    }
}

