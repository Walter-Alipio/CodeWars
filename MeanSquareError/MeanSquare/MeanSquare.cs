namespace MeanSquare;

///<Sumary>
/// Complete the function that
///    
/// accepts two integer arrays of equal length
/// compares the value each member in one array to the corresponding member in the other
/// squares the absolute value difference between those two values
/// and returns the average of those squared absolute value difference between each member pair.
///</Sumary>
public class MeanSquare
{
    public static double Kata(int[] firstArray, int[] secondArray)
    {
        double squareOfPairs = 0;
        for (int i = 0; i < firstArray.Length; i++)
        {
            squareOfPairs += Math.Pow(firstArray[i] - secondArray[i], 2);
        }
        return squareOfPairs / firstArray.Length;
    }
}
