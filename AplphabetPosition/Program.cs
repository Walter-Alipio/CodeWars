//my solution
string text = "The sunset sets at twelve o' clock.";
string alphabet = "abcdefghijklmnopqrstuvwxyz";
string resp = string.Empty;
text = text.ToLower();

foreach (var letter in text)
{
  if (alphabet.Contains(letter))
  {
    resp += (alphabet.IndexOf(letter) + 1).ToString() + " ";
  }
}

System.Console.WriteLine("Com foreach: " + resp);


//Communit solution
string text2 = "The sunset sets at twelve o' clock.";
string alphabet2 = "abcdefghijklmnopqrstuvwxyz";

string resp2 = string.Join(" ", text2.ToLower()
  .Where(c => char.IsLetter(c))
  .Select(c => alphabet.IndexOf(c) + 1).ToArray());

System.Console.WriteLine("Com LINQ: " + resp2);