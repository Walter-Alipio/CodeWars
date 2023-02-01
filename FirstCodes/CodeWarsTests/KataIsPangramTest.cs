using IsPangram;

public class KataIsPangramTest
{
  [Fact]
  public void TestIsPangramTrue()
  {
    // Given
    // When
    // Then
    Assert.True(KataIsPangram.IsPangram("The quick brown fox jumps over the lazy dog"));
  }

  [Fact]
  public void TestIsPangramFalse()
  {
    // Given
    // When
    // Then
    Assert.False(KataIsPangram.IsPangram("abcdefghijklmopqrstuvwxyz "));
  }

  [Fact]
  public void TestCommunityAnswerTrue()
  {
    // Given
    // When
    // Then
    Assert.True(KataIsPangram.IsPangramCommunityAnswer("The quick brown fox jumps over the lazy dog"));
  }

  [Fact]
  public void TestCommunityAnswerFalse()
  {
    // Given
    // When
    // Then
    Assert.False(KataIsPangram.IsPangramCommunityAnswer("abcdefghijklmopqrstuvwxyz "));
  }
}