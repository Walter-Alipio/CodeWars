using System.Text.RegularExpressions;

namespace IsPangram;

///<summary>
/// A pangram is a sentence that contains every single letter of the alphabet at least once.For example, the sentence 
///"The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once(case is irrelevant). 
///Given a string, detect whether or not it is a pangram.Return True if it is, False if not.
///<summary>
public class KataIsPangram
{

  public static bool IsPangram(string str)
  {
    //Remove espaços em branco e pontuação.
    var test = Regex.Replace(str, @"[^a-zA-Z]", "");
    //Gera uma nova string removendo caracteres repetidos.
    string result = String.Join("", test.ToUpper().Distinct());
    //define se a nova string contém todas as 26 letras do alfabeto.
    return result.Count().Equals(26);
  }

  //Answer from user Souzooka
  public static bool IsPangramCommunityAnswer(string str)
  {
    return str.ToLower()
       .Where(Char.IsLetter)
       .Distinct()
       .Count() == 26;
  }

}
