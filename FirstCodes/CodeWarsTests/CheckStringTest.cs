using Alphanumeric;

namespace CodeWarsTests;

public class CheckStringTest
{
  [Theory]
  [InlineData("Lola")]
  [InlineData("PassW0rd")]
  public void TestIfStringAlphanumericReturnTrue(string word)
  {
    Assert.True(CheckString.ifStringAlphanumeric(word));
  }
  [Theory]
  [InlineData("hello world_")]
  [InlineData("      ")]
  [InlineData("")]
  public void TestIfStringAlphanumericReturnFalse(string word)
  {
    Assert.False(CheckString.ifStringAlphanumeric(word));
  }
}

