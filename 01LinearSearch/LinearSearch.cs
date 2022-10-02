namespace _01LinearSearch;

public class LinearSearch
{
    public bool Search(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }

        return false;
    }
}

