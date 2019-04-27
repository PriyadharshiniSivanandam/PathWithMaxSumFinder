using Microsoft.VisualStudio.TestTools.UnitTesting;

using PathWithMaxSumFinder;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void Sum_EventParent_ResultSum()
    {
      //Arrange
      var parent = 12;
      var child1 = 5;
      var child2 = 6;

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var sum = helper.Sum(parent, child1, child2);

      //Assert
      Assert.AreEqual(17, sum);
    }

    [TestMethod]
    public void Sum_OddParent_ResultSum()
    {
      //Arrange
      var parent = 13;
      var child1 = 5;
      var child2 = 6;

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var sum = helper.Sum(parent, child1, child2);

      //Assert
      Assert.AreEqual(19, sum);
    }

    [TestMethod]
    public void Sum_OddChild_ResultSum()
    {
      //Arrange
      var parent = 14;
      var child1 = 5;
      var child2 = 9;

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var sum = helper.Sum(parent, child1, child2);

      //Assert
      Assert.AreEqual(23, sum);
    }

    [TestMethod]
    public void Sum_SameChild_ResultSum()
    {
      //Arrange
      var parent = 14;
      var child1 = 6;
      var child2 = 8;

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var sum = helper.Sum(parent, child1, child2);

      //Assert
      Assert.AreEqual(0, sum);
    }

    [TestMethod]
    public void MaximumSumCalculator_Input_Sum()
    {
      //Arrange
      var inputArray = GetInputArray();

      //Act
      var calculator = new MaximumSumCalculator();
      var maximumSum = calculator.CalculateSum(inputArray);

      //Assert
      Assert.AreEqual(22, maximumSum);
    }

    [TestMethod]
    public void CreateArrayWithRequiredData_Input_NewArray()
    {
      //Arrange
      var inputArray = GetInputArray();

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var outputArray = helper.CreateArrayWithRequiredData(inputArray);

      //Assert
      Assert.AreEqual(1, outputArray[0, 0]);
      Assert.AreEqual(1, outputArray[1, 0]);
      Assert.AreEqual(5, outputArray[1, 1]);
      Assert.AreEqual(9, outputArray[1, 2]);
    }

    [TestMethod]
    public void FindAlternateEvenOddPath_Input_OutputArray()
    {
      //Arrange
      var inputArray = GetInputArray();

      //Act
      var helper = new AlternateEvenOddSumHelper();
      var outputArray = helper.FindAlternateEvenOddPath(inputArray);

      //Assert
      Assert.AreEqual(9, outputArray[0, 0]);
      Assert.AreEqual(5, outputArray[1, 0]);
      Assert.AreEqual(7, outputArray[1, 1]);
      Assert.AreEqual(11, outputArray[1, 2]);
    }

    #region Helper

    private int[,] GetInputArray()
    {
      int[,] inputArray = new int[4, 5];
      inputArray[0, 0] = 1;
      inputArray[1, 0] = 8;
      inputArray[1, 1] = 9;
      inputArray[2, 0] = 1;
      inputArray[2, 1] = 5;
      inputArray[2, 2] = 9;
      inputArray[3, 0] = 4;
      inputArray[3, 1] = 5;
      inputArray[3, 2] = 2;
      inputArray[3, 3] = 3;

      return inputArray;
    }

    #endregion
  }
}
