﻿namespace _04BubbleSort;

public class BubbleSort
{
    public int[] Sort(int[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }

        return arr;
    }

    public int[] Sort2(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }

        return arr;
    }
}

