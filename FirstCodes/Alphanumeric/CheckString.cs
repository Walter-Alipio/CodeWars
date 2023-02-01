

namespace Alphanumeric;

///<Sumary>
/// In this example you have to validate if a user input string is alphanumeric.The given
/// string is not nil/null/NULL/None, so you don't have to check that.
///
/// The string has the following conditions to be alphanumeric:
///
/// At least one character ("" is not valid)
/// Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
/// No whitespaces / underscore
///</Sumary>
public class CheckString
{
  public static bool ifStringAlphanumeric(string str)
  {
    // var res = str.Where(char.IsLetterOrDigit).Count() == str.Length;
    return String.IsNullOrEmpty(str) ? false : str.All(s => char.IsLetterOrDigit(s));
  }
  //Community answer using Regex
  //  return new Regex("^[a-zA-Z0-9]+$").Match(str).Success;
}
