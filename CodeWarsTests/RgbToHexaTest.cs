using RgbConvert;

namespace CodeWarsTests;

public class RgbToHexaTest
{

  [Theory]
  [InlineData("FFFFFF", 255, 255, 255)]
  [InlineData("FFFFFF", 255, 255, 300)]
  [InlineData("000000", 0, 0, 0)]
  [InlineData("9400D3", 148, 0, 211)]
  [InlineData("9400D3", 148, -20, 211)]
  [InlineData("90C3D4", 144, 195, 212)]
  [InlineData("FFFFFF", 255, 255, 300)]
  [InlineData("D4350C", 212, 53, 12)]
  public void TestConverToHexaReturnTrue(
    string result,
    int red,
    int green,
    int blue)
  {
    // Given
    // When
    // Then
    Assert.True(result.Equals(RgbToHexa.ConvertToHexa(red, green, blue)));
  }

}