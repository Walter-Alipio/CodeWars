namespace findOdd;

///<Sumary>
/// Given an array of integers, find the one that appears an odd number of times.
/// There will always be only one integer that appears an odd number of times.
///</Sumary>
public class FindRepeated
{
  public static int FindRepeatedOddTimes(int[] array)
  {

    return array
      .Where(num => Array.FindAll(array, i => i.Equals(num)).Count() % 2 != 0)
      .Select(num => num).First();
  }
  //Community solution
  // return array.Aggregate(0, (a, b) => a ^ b);
}
