using Xunit;
using findOuntlier;


namespace CodeWarsTests;

public class UnitTest1
{
  [Fact]
  public void TestFindOutlierEvenInteger()
  {
    //Arrange
    int[] evenInt = new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 };
    //Act
    int result = FindOutlier.Find(evenInt);
    System.Console.WriteLine(result);
    //Assert
    Assert.Equal(11, result);

  }

  [Fact]
  public void TestFindOutlierOddInteger()
  {
    //Arrange
    int[] evenInt = new int[] { 160, 3, 1719, 19, 11, 13, -21 };
    //Act
    int result = FindOutlier.Find(evenInt);
    System.Console.WriteLine(result);
    //Assert
    Assert.Equal(160, result);
  }
}