namespace Xbonacci;

public class Hakonacci
{
  //n especifica o número de caracteres da sequencia a serem apresentados
  //signature define os 3 primeiros dígitos.
  public double[] Tribonacci(double[] signature, int n)
  {

    if (n == 0) return new double[0];

    if (n <= signature.Length)
    {
      Array.Resize<double>(ref signature, n);
      return signature;
    }

    n -= 3;
    List<double> sequence = new List<double>(signature);
    for (int i = 0; i < n; i++)
    {
      sequence.Add(
        (sequence[sequence.Count - 1]) +
        (sequence[sequence.Count - 2]) +
        (sequence[sequence.Count - 3])
        );
    }

    // hackonacci me
    return sequence.ToArray();
  }
}
