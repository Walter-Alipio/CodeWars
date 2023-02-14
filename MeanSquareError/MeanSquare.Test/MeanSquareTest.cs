namespace MeanSquare.Test;

public class MeanSquareTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, 9)]
    [InlineData(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }, 16.5)]
    [InlineData(new int[] { 0, -1 }, new int[] { -1, 0 }, 1)]
    public void TestKata(int[] firstArray, int[] secondArray, double expect)
    {
        //Arrange
        //Act
        Double result = MeanSquare.Kata(firstArray, secondArray);
        //Assert
        Assert.Equal(expect, result);
    }
}