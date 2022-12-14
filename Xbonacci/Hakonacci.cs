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

    var sequenceLength = signature.Length;

    n -= 3;
    List<double> sequence = new List<double>(signature);
    for (int i = 0; i < n; i++)
    {
      sequence.Add(
        (sequence[sequenceLength - 1]) +
        (sequence[sequenceLength - 2]) +
        (sequence[sequenceLength - 3])
        );

      sequenceLength++;
    }

    // hackonacci me
    return sequence.ToArray();
  }
}
