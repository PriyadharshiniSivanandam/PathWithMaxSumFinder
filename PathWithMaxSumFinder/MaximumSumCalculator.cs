using System;

namespace PathWithMaxSumFinder
{
  /// <summary>
  /// Class to calculate the MaximumSum in the given array.
  /// </summary>
  public class MaximumSumCalculator
  {
    /// <summary>
    /// Maximum sum calculator.
    /// </summary>
    /// <param name="inputArray">Input Array</param>
    /// <returns>Maximum Sum</returns>
   public int CalculateSum(int[,] inputArray)
    {
      var length = inputArray.GetLength(0);

      for (var i = length - 2; i >= 0; i--)
      {
        for (var j = 0; j < length; j++)
        {
          var parentNode = inputArray[i, j];
          var childNode1 = inputArray[i + 1, j];
          var childNode2 = inputArray[i + 1, j + 1];

          inputArray[i, j] = parentNode + Math.Max(childNode1, childNode2);
        }
      }

      return inputArray[0, 0];
    }
  }
}
