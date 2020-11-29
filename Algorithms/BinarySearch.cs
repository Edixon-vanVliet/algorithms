using System;

namespace Algorithms
{
  public static class BinarySearch
  {
    public static int IndexOf<T>(T[] input, T key) where T : IComparable<T>
    {
      int low = 0, high = input.Length - 1;

      while (low <= high)
      {
        int middle = low + (high - low) / 2;
        if (key.CompareTo(input[middle]) < 0)
        {
          high = middle - 1;
        }
        else if (key.CompareTo(input[middle]) > 0)
        {
          low = middle + 1;
        }
        else
        {
          return middle;
        }
      }

      return -1;
    }
  }
}