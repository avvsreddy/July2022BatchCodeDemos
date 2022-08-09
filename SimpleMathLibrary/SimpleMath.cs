using SimpleMathDataLayer;
using SimpleMathLibrary;
/// <summary>
/// Use this class for calculating simple mathematical operations
/// </summary>
public class SimpleMath // back end
{

    IDbRepository repo = null;



    public SimpleMath()
    {
        repo = new DbRepository();
    }

    public SimpleMath(IDbRepository repo)
    {
        this.repo = repo;
    }

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
        //SimpleMathDataLayer.DbRepository repo = new SimpleMathDataLayer.DbRepository();
        repo.SaveData(a, b, sum);
        return sum;
    }
}