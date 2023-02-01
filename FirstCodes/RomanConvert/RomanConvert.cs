namespace RomanConvert;
public class RomanConvert
{
  public static string MySolution(int n)
  {
    if (n > 3999 || n <= 0) return "Out of bounds - Range 1 - 3999";

    var reverseSeq = n.ToString().Reverse().ToArray();

    List<Func<char, string>> numbers = new List<Func<char, string>>
    {
     num1 => RomanNumbers(num1),
     num2=> RomanTens(num2),
     num3 => RomanHundreds(num3),
     num4 => RomanThousands(num4)
    };

    List<string> result = new();

    for (int i = 0; i < reverseSeq.Length; i++)
    {
      result.Add(numbers[i].Invoke(reverseSeq[i]));
    }

    result.Reverse();

    return String.Join("", result);
  }

  private static string RomanNumbers(char n)
  {
    if (n == '0') return "";

    Dictionary<char, string> roman = new Dictionary<char, string>()
    {
      {'1',"I"},
      {'2',"II"},
      {'3',"III"},
      {'4',"IV"},
      {'5',"V"},
      {'6',"VI"},
      {'7',"VII"},
      {'8',"VIII"},
      {'9',"IX"}
    };
    return roman[n];
  }
  private static string RomanTens(char n)
  {
    if (n == '0') return "";

    Dictionary<char, string> roman = new Dictionary<char, string>()
    {
      {'1',"X"},
      {'2',"XX"},
      {'3',"XXX"},
      {'4',"XL"},
      {'5',"L"},
      {'6',"LX"},
      {'7',"LXX"},
      {'8',"LXXX"},
      {'9',"XC"}
    };
    return roman[n];
  }
  private static string RomanHundreds(char n)
  {
    if (n == '0') return "";

    Dictionary<char, string> roman = new Dictionary<char, string>()
    {
      {'1',"C"},
      {'2',"CC"},
      {'3',"CCC"},
      {'4',"CD"},
      {'5',"D"},
      {'6',"DC"},
      {'7',"DCC"},
      {'8',"DCCC"},
      {'9',"CM"}
    };
    return roman[n];
  }
  private static string RomanThousands(char n)
  {
    Dictionary<char, string> roman = new Dictionary<char, string>()
    {
      {'1',"M"},
      {'2',"MM"},
      {'3',"MMM"},
    };
    return roman[n];
  }

  //Community solution  
  public static string Solution(int n)
  {
    string roman = "";
    string[] thousand = { "", "M", "MM", "MMM" };
    string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    roman += thousand[(n / 1000) % 10];
    roman += hundred[(n / 100) % 10];
    roman += ten[(n / 10) % 10];
    roman += one[n % 10];

    return roman;

  }
}
