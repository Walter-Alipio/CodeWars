using System.Linq;
///<Summary>
///In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". Your
/// function receives one side of the DNA (string, except for Haskell); you need to return
/// the other complementary side. DNA strand is never empty or there is no DNA 
///at all (again, except for Haskell).
///</Summary>
static string MakeComplement(string dna)
{
  dna.ToUpper();
  string result = String.Empty;
  foreach (var c in dna)
  {
    if (c == 'A')
      result += 'T';

    if (c == 'T')
      result += 'A';

    if (c == 'C')
      result += 'G';

    if (c == 'G')
      result += 'C';
  }
  return result;
}

System.Console.WriteLine($"ATTGC: {MakeComplement("ATTGC")}");
System.Console.WriteLine($"GTAT: {MakeComplement("GTAT")}");

static string MakeComplementLINQ(string dna)
{
  dna.ToUpper();
  string result = String.Empty;
  for (int i = 0; i < dna.Length; i++)
  {
    switch (dna[i])
    {
      case 'A':
        result += 'T';
        break;
      case 'T':
        result += 'A';
        break;
      case 'C':
        result += 'G';
        break;
      case 'G':
        result += 'C';
        break;
      default:
        throw new ArgumentNullException();
    }

  }
  return result;
}

System.Console.WriteLine($"ATTGC: {MakeComplementLINQ("ATTGC")}");
System.Console.WriteLine($"GTAT: {MakeComplementLINQ("GTAT")}");


//Community answer user Artoria

static string MakeComplementWithElegancy(string dna)
{
  return String.Join("",
         from ch in dna
         select "AGCT"["TCGA".IndexOf(ch)]
        );
}

System.Console.WriteLine($"ATTGC: {MakeComplementWithElegancy("ATTGC")}");
System.Console.WriteLine($"GTAT: {MakeComplementWithElegancy("GTAT")}");