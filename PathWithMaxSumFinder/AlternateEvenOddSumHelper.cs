using System;

namespace PathWithMaxSumFinder
{
  /// <summary>
  /// Helper class to traverse through the input array and find maximum sum path with even-odd criteria.
  /// </summary>
  public class AlternateEvenOddSumHelper
  {
    public int[,] FindAlternateEvenOddPath(int[,] inputArray)
    {
      var length = inputArray.GetLength(0);

      int[,] arrayWithEvenOddSum = new int[length, length + 1];
      for (var i = 0; i <= length - 2; i = i + 2)
      {
        for (var j = 0; j <= i; j++)
        {
          var parentNode = inputArray[i, j];
          var childNode1 = inputArray[i + 1, j];
          var childNode2 = inputArray[i + 1, j + 1];

          arrayWithEvenOddSum[i, j] = Sum(parentNode, childNode1, childNode2);
        }
      }

      return CreateArrayWithRequiredData(arrayWithEvenOddSum);
    }

    static bool IsEven(int number)
    {
      return number % 2 == 0;
    }

    /// <summary>
    /// Method to calculate sum of alternate even-odd nodes.
    /// </summary>
    /// <param name="parent">ParentNode</param>
    /// <param name="child1">ChildNode1</param>
    /// <param name="child2">ChildNode2</param>
    /// <returns>Sum of the Nodes</returns>
   public int Sum(int parent, int child1, int child2)
    {
      if (IsEven(parent))
      {
        if (!IsEven(child1) && !IsEven(child2))
          return parent + Math.Max(child1, child2);

        if (!IsEven(child1))
          return parent + child1;

        if (!IsEven(child2))
          return parent + child2;
      }

      else if (!IsEven(parent))
      {
        if (IsEven(child1) && IsEven(child2))
          return parent + Math.Max(child1, child2);

        if (IsEven(child1))
          return parent + child1;

        if (IsEven(child2))
          return parent + child2;
      }

      return 0;
    }

    /// <summary>
    /// Method to return array by removing duplicate records from the given array.
    /// </summary>
    /// <param name="inputArray">Input Array</param>
    /// <returns>Array with required data</returns>
    public int[,] CreateArrayWithRequiredData(int[,] inputArray)
    {
      var length = inputArray.GetLength(0);
      int[,] newArray = new int[length, length + 1];

      for (var i = 0; i <= length - 2; i = i + 2)
      {
        for (var j = 0; j < length; j++)
        {
          if (i == 0)
            newArray[i, j] = inputArray[i, j];
          else
            newArray[i - 1, j] = inputArray[i, j];
        }
      }

      return newArray;
    }
  }
}
