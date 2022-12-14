using Xbonacci;

namespace CodeWarsTests;
public class XbonacciTest
{
  [Theory]
  [InlineData(new double[] { 1, 1, 1 }, new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 })]
  [InlineData(new double[] { 0, 0, 1 }, new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 })]
  [InlineData(new double[] { 0, 1, 1 }, new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 })]
  public void TestTribonacci(double[] signature, double[] expect)
  {
    // Given
    var xbonacci = new Hakonacci();
    // When
    var result = xbonacci.Tribonacci(signature, 10);
    // Then
    Assert.Equal(expect, result);
  }

  [Theory]
  [InlineData(new double[] { 1, 1, 1 }, 1)]
  [InlineData(new double[] { 1, 1, 1 }, 2)]
  [InlineData(new double[] { 1, 1, 1 }, 3)]
  public void TestTribonacciWithNlessThenLength(double[] signature, int n)
  {
    //Arrange
    var xbonacci = new Hakonacci();
    //Act
    var result = xbonacci.Tribonacci(signature, n);
    //Assert
    Assert.Equal(n, result.Length);
  }
}

// new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
// new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
// new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));