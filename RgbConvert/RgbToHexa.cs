namespace RgbConvert;

/// <Sumary>
/// The rgb function is incomplete.Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
/// Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
/// </Sumary>
public class RgbToHexa
{
  public static string ConvertToHexa(int r, int g, int b)
  {

    string result = $"{GetHexadecimal(r)}{GetHexadecimal(g)}{GetHexadecimal(b)}";

    return result;
  }

  private static string GetHexadecimal(int number)
  {
    var hexa = Math.Clamp(number, 0, 255);

    return hexa.ToString("X2");
  }


  //Community resolution

  //return $"{(r > 255 ? 255 : r < 0 ? 0 : r):X2}" + 
  //  $"{(g > 255 ? 255 : g < 0 ? 0 : g):X2}" +
  //  $"{(b > 255 ? 255 : b < 0 ? 0 : b):X2}";
}
