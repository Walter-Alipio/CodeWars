using System.Collections.Generic;
namespace findOuntlier;
public class FindOutlier
{

  public static int Find(int[] integers)
  {
    List<int> evenInt = new List<int>();
    List<int> oddInt = new List<int>();

    for (int i = 0; i < integers.Length; i++)
    {
      if (integers[i] % 2 == 0)
      {
        evenInt.Add(integers[i]);
      }
      else
      {
        oddInt.Add(integers[i]);
      }
    }

    return evenInt.Count() <= 1 ? evenInt[0] : oddInt[0];
  }
}
