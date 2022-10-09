namespace _01LinearSearch;

public class LinearSearch
{
    public bool Search(int[] haystack, int needle)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle)
            {
                return true;
            }
        }

        return false;
    }
}

