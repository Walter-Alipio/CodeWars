using Multiples3or5;

namespace CodeWarsTests;

public class Multiples3or5Test
{
  [Fact]
  public void TestMultiles3or5Return0()
  {
    Assert.Equal(0, Multiples.Solution(-23));
  }

  [Theory]
  [InlineData(10, 23)]
  [InlineData(20, 78)]
  [InlineData(12000, 33594000)]
  public void TestMultiles3or5ReturnSumOfThen(int value, int result)
  {
    Assert.Equal(result, Multiples.Solution(value));
  }
}