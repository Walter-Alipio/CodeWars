namespace HumanReadableTime.TimeFormat;
public class TimeFormat
{
  public static string GetReadableTime(int seconds)
  {
    var span = TimeSpan.FromSeconds(seconds);
    return String.Format("{0:00}:{1:00}:{2:00}", (int)span.TotalHours, span.Minutes, span.Seconds);
  }

}
