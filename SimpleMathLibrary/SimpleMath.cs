
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
    public int Sum(int a, int b)
    {
        if (a % 2 == 0 || b % 2 == 0)
            return a + b;
        throw new InvalidEvenNumberException("Enter atleast one even number");
    }
}