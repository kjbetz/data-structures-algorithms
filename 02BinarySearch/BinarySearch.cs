namespace _02BinarySearch;

public class BinarySearch
{
    public bool Search(int[] haystack, int needle)
    {
        int low = 0;
        int high = haystack.Length;

        do  
        {
            int m = low + (high - low) / 2;
            int v = haystack[m];

            if (v == needle)
            {
                return true;
            }
            else if (v > needle)
            {
                high = m;
            }
            else
            {
                low = m + 1;
            }
        } while (low < high);

        return false;
    }
}

