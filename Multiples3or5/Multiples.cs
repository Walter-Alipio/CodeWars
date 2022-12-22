namespace Multiples3or5;

/// <Summary>
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
/// Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
/// Note: If the number is a multiple of both 3 and 5, only count it once.
/// </Summary>
public class Multiples
{
  public static int Solution(int value)
  {

    if (value <= 0) return 0;

    ISet<int> list = new HashSet<int>();
    for (int i = 0; i < value; i++)
    {
      if (i % 3 == 0 || i % 5 == 0)
      {
        list.Add(i);
      }
    }

    return list.Sum();
  }

  //Community solution
  public static int CommunitySolution(int value)
  {
    int max = value - 1;
    int count3 = max / 3;
    int count5 = max / 5;
    int count15 = max / 15;
    return 3 * Sum(count3) + 5 * Sum(count5) - 15 * Sum(count15);
  }

  private static int Sum(int value)
  {
    return (1 + value) * value / 2;
  }
  // //Explains:
  // There is a given formula for the sum of natural numbers up to N and it is N* (N+1)/2. Since multiples of 3 are 3, 6, 9, 12.... they could be writen as 3*(1, 2, 3, 4, 5...) and thus the sum is 3 * (nMultiplesOf3* (nMultiplesOf3 + 1 ) / 2 ) Same happens for multiples of 5 and 15, and you have to remove the multiples of 15 because they are added twice: in multiples of 3 and multiples of 5

  //But this solution forget about negative numbers.
}

