using RomanConvert;

namespace CodeWarsTests;

public class RomanConverTest
{
  [Fact]
  public void TestMySolutionReturnString()
  {
    // Given

    // When
    var result = RomanConvert.RomanConvert.MySolution(10);
    // Then
    Assert.IsType<String>(result);
  }

  [Theory]
  [InlineData(1, "I")]
  [InlineData(2, "II")]
  [InlineData(4, "IV")]
  [InlineData(500, "D")]
  [InlineData(1000, "M")]
  [InlineData(1954, "MCMLIV")]
  [InlineData(1990, "MCMXC")]
  [InlineData(2008, "MMVIII")]
  public void TestMysolutionReturnTrue(int test, string result)
  {

    Assert.Equal(result, RomanConvert.RomanConvert.MySolution(test));
  }
}