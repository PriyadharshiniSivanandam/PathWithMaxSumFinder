using System;

using System.IO;

namespace PathWithMaxSumFinder
{
  /// <summary>
  /// Class to find the  maximum possible sum of the numbers from a given triangle input.
  /// </summary>
  public class PathFinderAlgorithm
  {
    static void Main()
    {
      String data = File.ReadAllText(@"C:\FileToRead\Input.txt");

      var input = ConvertDataToInputArray(data);

      var pathFinder = new AlternateEvenOddSumHelper();
      var arrayWithEvenOddSum = pathFinder.FindAlternateEvenOddPath(input);

      var calculator = new MaximumSumCalculator();
      var maximumSum = calculator.CalculateSum(arrayWithEvenOddSum);

      Console.WriteLine($"The maximum possible sum of the numbers in the given triangle input is :  {maximumSum}");
      Console.WriteLine("Press any Key to close.");
      Console.ReadKey();
    }

    /// <summary>
    /// Method to convert input data to array.
    /// </summary>
    /// <param name="data">String Input</param>
    /// <returns></returns>
    static int[,] ConvertDataToInputArray(String data)
    {
      var input = data.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

      int i = 0;
      int[,] result = new int[input.Length, input.Length + 1];

      foreach (var row in input)
      {
        int j = 0;
        foreach (var col in row.Trim().Split(' '))
        {
          result[i, j] = int.Parse(col.Trim());
          j++;
        }

        i++;
      }

      return result;
    }
  }
}
