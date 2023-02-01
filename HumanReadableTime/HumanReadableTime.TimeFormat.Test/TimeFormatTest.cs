
namespace HumanReadableTime.TimeFormat.Test;

public class TimeFormatTest
{
  [Theory]
  [InlineData("00:00:00", 0)]
  [InlineData("00:00:05", 5)]
  [InlineData("00:01:00", 60)]
  [InlineData("23:59:59", 86399)]
  [InlineData("99:59:59", 359999)]
  public void TestTimeFormatReturnsTrue(string result, int seconds)
  {
    Assert.Equal(result, TimeFormat.GetReadableTime(seconds));
  }
}