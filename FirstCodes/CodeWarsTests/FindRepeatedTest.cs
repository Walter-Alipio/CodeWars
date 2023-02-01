using findOdd;

namespace CodeWarsTests;

public class FindRepeatedTest
{
  [Theory]
  [InlineData(7, new[] { 7 })]
  [InlineData(7, new[] { 7 })]
  [InlineData(2, new[] { 1, 1, 2 })]
  [InlineData(4, new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 })]
  public void TestFindRepeated(int expected, int[] param)
  {
    // Given
    // When
    // Then
    Assert.Equal(expected, FindRepeated.FindRepeatedOddTimes(param));
  }
}