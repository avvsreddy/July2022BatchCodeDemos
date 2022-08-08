
using SimpleMathDataLayer;
using SimpleMathLibrary;
/// <summary>
/// Use this class for calculating simple mathematical operations
/// </summary>
public class SimpleMath // back end
{
    /// <summary>
    /// Finds the sum of two numbers. atleast one number should be even
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>the sum</returns>
    /// <exception cref="InvalidEvenNumberException"></exception>
    /// <exception cref="InvalidPositiveNonZeroNumberException"></exception>
    public int Sum(int a, int b)
    {
        if (a % 2 != 0 && b % 2 != 0)
            throw new InvalidEvenNumberException("Enter atleast one even number");

        if (a <= 0 || b <= 0)
            throw new InvalidPositiveNonZeroNumberException("Enter atlease one positive non zero number");

        int sum = a + b;
        DbRepository repo = new DbRepository();
        try
        {
            repo.SaveData(a, b, sum);
        }
        catch (Exception ex)
        {
            ///////
            /////
            // log
            // convert
            // fix
            throw ex;
        }
        return sum;



    }
}