namespace findOdd;

///<Sumary>
/// Given an array of integers, find the one that appears an odd number of times.
/// There will always be only one integer that appears an odd number of times.
///</Sumary>
public class FindRepeated
{
  public static int FindRepeatedOddTimes(int[] array)
  {
    // var elements = array.Distinct().ToArray();
    // int result = 0;

    // for (int i = 0; i < array.Length; i++)
    // {
    //   var test = Array.FindAll(array, num => num.Equals(elements[i]));
    //   if (test.Length % 2 != 0)
    //   {
    //     result = elements[i];
    //     break;
    //   }
    // }
    // System.Console.WriteLine(result);

    return array
      .Where(num => Array.FindAll(array, i => i.Equals(num)).Count() % 2 != 0)
      .Select(num => num).First();
  }
  //Community solution
  // return array.Aggregate(0, (a, b) => a ^ b);
}
