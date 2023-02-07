namespace Decipher.Code;
public class ROT13
{
    /// <Summary>
    /// ROT13("rotate by 13 places", sometimes hyphenated ROT-13) is a simple letter substitution cipher
    /// that replaces a letter with the 13th letter after it in the alphabet.
    /// Applying ROT13 to a piece of text merely requires examining its alphabetic characters
    /// and replacing each one by the letter 13 places further along in the alphabet, 
    /// wrapping back to the beginning if necessary. 
    /// </Summary>
    public static string? Rot13(string input)
    {
        string res = string.Empty;

        foreach (var c in input)
        {
            var ascII = (int)c;
            if ((ascII > 96 && ascII < 110) || (ascII > 64 && ascII < 78))
            {
                res += (char)(ascII + 13);
                continue;
            }

            if ((ascII > 109 && ascII < 123) || (ascII > 77 && ascII < 91))
            {
                res += (char)(ascII - 13);
                continue;
            }
            res += c;
        }
        return res;
    }

}
